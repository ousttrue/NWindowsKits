﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NWindowsKits;

namespace SampleLib
{
    public class FPSTimer
    {
        uint m_last;
        readonly int m_msInFrame;

        public FPSTimer(int fps)
        {
            m_last = winmm.timeGetTime();
            m_msInFrame = 1000 / fps - 5;
        }

        public void Update(Action frameAction)
        {
            var now = winmm.timeGetTime();
            var delta = (int)(now - m_last);
            if (delta > m_msInFrame)
            {
                frameAction();
                m_last = now;
            }
            else
            {
                Thread.Sleep(m_msInFrame - delta);
            }
        }
    }

    public class MessageLoop
    {
        class CustomSynchronizationContext : SynchronizationContext
        {
            readonly Queue<(SendOrPostCallback, object)> m_queue = new Queue<(SendOrPostCallback, object)>();
            public override void Post(SendOrPostCallback d, object state)
            {
                lock (((ICollection)m_queue).SyncRoot)
                {
                    m_queue.Enqueue((d, state));
                }
            }

            readonly List<(SendOrPostCallback, object)> m_dequeue = new List<(SendOrPostCallback, object)>();
            public void Process()
            {
                lock (((ICollection)m_queue).SyncRoot)
                {
                    m_dequeue.AddRange(m_queue);
                    m_queue.Clear();
                }

                foreach (var (callback, obj) in m_dequeue)
                {
                    callback(obj);
                }
                m_dequeue.Clear();
            }
        }

        [ThreadStatic]
        static CustomSynchronizationContext s_context;
        public static void EnsureContext()
        {
            if (s_context == null)
            {
                s_context = new CustomSynchronizationContext();
                SynchronizationContext.SetSynchronizationContext(s_context);
            }
        }

        public static void ProcessMessage(out bool isQuit)
        {
            EnsureContext();

            MSG msg = default;
            while (user32.PeekMessageW(ref msg, default, 0, 0, C.PM_REMOVE) != 0)
            {
                if (msg.message == C.WM_QUIT)
                {
                    isQuit = true;
                    return;
                }
                user32.TranslateMessage(ref msg);
                user32.DispatchMessageW(ref msg);
            }
            isQuit = false;

            // process tasks
            s_context.Process();
        }

        public static void Run(Action draw, int fps)
        {
            var timer = new FPSTimer(1000 / fps);
            while (true)
            {
                ProcessMessage(out bool isQuit);
                if (isQuit)
                {
                    return;
                }

                timer.Update(draw);
            }
        }
    }
}
