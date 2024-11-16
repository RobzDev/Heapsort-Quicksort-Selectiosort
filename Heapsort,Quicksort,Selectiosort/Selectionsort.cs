using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SelectionSort
{
    private Action<int[]> UpdateListBoxAction;

    public SelectionSort(Action<int[]> updateListBoxAction)
    {
        UpdateListBoxAction = updateListBoxAction;
    }

    public async Task SelectionsortAsync(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Encuentra el índice del elemento mínimo en el subarreglo no ordenado
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Intercambia el elemento mínimo con el primer elemento no ordenado
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;

            // Pausa para visualizar el cambio y actualizar el ListBox
            await Task.Delay(500);
            UpdateListBoxAction?.Invoke(array);
        }
    }
}
