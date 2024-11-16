using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heapsort_Quicksort_Selectiosort
{
    public class QuickSort
    {
        private Action<int[]> UpdateListBoxAction;

        public QuickSort(Action<int[]> updateListBoxAction)
        {
            UpdateListBoxAction = updateListBoxAction;
        }

        public async Task QuicksortAsync(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = await PartitionAsync(arr, low, high);
                await QuicksortAsync(arr, low, pivotIndex - 1);
                await QuicksortAsync(arr, pivotIndex + 1, high);
            }
        }

        private async Task<int> PartitionAsync(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                    await Task.Delay(500); // Pausa para visualizar el cambio
                    UpdateListBox(arr);    // Actualizar ListBox
                }
            }

            Swap(arr, i + 1, high);
            await Task.Delay(500);         // Pausa para visualizar el cambio
            UpdateListBox(arr);            // Actualizar ListBox
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void UpdateListBox(int[] array)
        {
            UpdateListBoxAction?.Invoke(array);
        }
    }

}
