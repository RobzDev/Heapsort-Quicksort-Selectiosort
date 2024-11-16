using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HeapSort
{
    private Action<int[]> UpdateListBoxAction;

    public HeapSort(Action<int[]> updateListBoxAction)
    {
        UpdateListBoxAction = updateListBoxAction;
    }

    public async Task HeapsortAsync(int[] array)
    {
        int n = array.Length;

        // Construir el max-heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            await HeapifyAsync(array, n, i);
        }

        // Extraer elementos del heap uno por uno
        for (int i = n - 1; i >= 0; i--)
        {
            // Mueve la raíz (el máximo) al final
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            // Actualiza el ListBox
            UpdateListBoxAction?.Invoke(array);
            await Task.Delay(500);

            // Llama a Heapify en el heap reducido
            await HeapifyAsync(array, i, 0);
        }
    }

    private async Task HeapifyAsync(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        // Si el hijo izquierdo es mayor que la raíz
        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        // Si el hijo derecho es mayor que el mayor hasta ahora
        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        // Si el mayor no es la raíz
        if (largest != i)
        {
            int swap = array[i];
            array[i] = array[largest];
            array[largest] = swap;

            // Actualiza el ListBox
            UpdateListBoxAction?.Invoke(array);
            await Task.Delay(500);

            // Recursivamente heapify el subárbol afectado
            await HeapifyAsync(array, n, largest);
        }
    }
}
