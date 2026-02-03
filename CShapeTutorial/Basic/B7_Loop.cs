using System.Collections.Generic;

namespace CShapeTutorial.Basic
{
    public class B7_Loop
    {
        void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
            }
        }

        void WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                i++;
            }
        }

        void DoWhileLoop()
        {
            int i = 0;
            do
            {
                i++;
            } while (i < 10);
        }

        void ForEachLoop()
        {
            List<int> temp = new List<int>();
            foreach (int i in temp)
            {
            }
        }

        void BreakContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) break;
                continue;
            }
        }
    }
}