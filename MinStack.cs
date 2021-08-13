/* 155. Min Stack */
public class MinStack
    {

        int[] array;
        int min;
        /** initialize your data structure here. */
        public MinStack()
        {
            array = new int[0];
        }

        public void Push(int val)
        {
            int[] temp = this.array;

            array = new int[array.Length + 1];
            array[0] = val;

            for (int i = 0; i < temp.Length; i++)
            {
                array[i + 1] = temp[i];
            }
        }

        public void Pop()
        {
            int[] temp = this.array;

            array = new int[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i + 1];
            }
        }

        public int Top()
        {
            return array[0];
        }

        public int GetMin()
        {
            int minValue = this.array[0];
            for (int i = 1; i < this.array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
    }

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
