using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOfficeTable
{
    public static class Animator
    {
        public static List<Animation> AnimationList = new List<Animation>();

        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread AnimatorThread;

        private static double Interval;

        public static void Start()
        {
            Interval = 10; // FPS ~65

            AnimatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            AnimatorThread.Start();
        }

        private static void AnimationInvoker()
        {
            while (true)
            {
                AnimationList.RemoveAll(a => a.Status == Animation.AnimationStatus.Completed);

                for (int i = 0; i < AnimationList.Count; i++)
                {
                    try
                    {
                        AnimationList[i].UpdateFrame();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Thread.Sleep((int)Interval);
            }
        }

        public static void Request(Animation Anim, bool ReplaceIfExists)
        {
            Anim.Status = Animation.AnimationStatus.Requested;

            Animation dupAnim = GetDuplicate(Anim);

            if (dupAnim != null)
            {
                if (ReplaceIfExists == true)
                {
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                }
                else
                {
                    return;
                }
            }

            AnimationList.Add(Anim);
        }

        private static Animation GetDuplicate(Animation Anim)
        {
            return AnimationList.Find(a => a.ID == Anim.ID);
        }
    }
}
