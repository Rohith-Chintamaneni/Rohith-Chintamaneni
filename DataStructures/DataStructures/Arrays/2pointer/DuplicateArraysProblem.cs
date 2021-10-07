namespace DataStructures.Arrays._2pointer
{
    public class DuplicateArraysProblem
    {
        // input [1,0,2,3,0,4,5,0] output:[1,0,0,2,3,0,0,4]
        public void DuplicateZeros(int[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == 0)
                {
                    ShiftArrayElements(arr, i);
                    i = i + 1;
                }
            }
        }

        public void ShiftArrayElements(int[] arr, int index)
        {
            for (int i = arr.Length-1; i > index; i--)
            {
                arr[i] = arr[i - 1];
               
            }
            arr[index] = 0;
        }


        // 2 pointer approach where we are overwriting the values from the right end
        public void DuplicateZerosSecondAppraoch(int[] A)
        {

            int n = A.Length, count = 0;

            foreach (var num in A)
            {
                if (num == 0) count++;
            }

            int i = n - 1;
            int j = n + count - 1;

            while (i != j)
            {
               InsertInArray(A, i, j); // overwrite J index element with i index element and decrement j
               j--; // decrement J
                if (A[i] == 0)
                {
                    InsertInArray(A, i, j);
                    j--;
                }

                i--;
            }

        }

        public void InsertInArray(int[] arr, int i, int j)
        {
            if (j < arr.Length) // you can only Overwrite when the J is less than array length
                arr[j] = arr[i];
        }
    }
}
