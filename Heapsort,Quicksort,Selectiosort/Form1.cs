namespace Heapsort_Quicksort_Selectiosort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] array;
        //private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //switch case to select the sorting algorithm
        //    switch (cbOption.SelectedIndex)
        //    {
        //        case 0:

        //            SelectionSort.Selectionsort(array);
        //            //print the sorted array in the textbox
        //            textBox1.Text = string.Join(", ", array);
        //            break;
        //        case 1:

        //            HeapSort.Heapsort(array);
        //            textBox1.Text = string.Join(", ", array);
        //            break;
        //        case 2:

        //            //QuickSort.Quicksort(array);
        //            break;
        //    }
        //}

        private void btnRandom_Click(object sender, EventArgs e)
        {

            //Generate a random array
            Random rand = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            //Display the array in the textbox
            tbArray.Text = string.Join(", ", array);
            this.array = array;


        }

        public void UpdateListBox(int[] array)
        {
            if (lboxArray.InvokeRequired)
            {
                lboxArray.Invoke(new Action(() => UpdateListBox(array)));
            }
            else
            {
                lboxArray.Items.Clear();
                foreach (var item in array)
                {
                    lboxArray.Items.Add(item);
                }
            }
        }

        private async void btnSort_Click(object sender, EventArgs e)
        {
            // Clear the ListBox
            lBoxunsorted.Items.Clear();
            foreach (var item in array)
            {
                lBoxunsorted.Items.Add(item);
            }

            switch (cbOption.SelectedIndex)
            {
                case 0:
                    SelectionSort selectionSorter = new SelectionSort(UpdateListBox);
                    await selectionSorter.SelectionsortAsync(array);
                    break;

                case 1:
                    HeapSort heapSorter = new HeapSort(UpdateListBox);
                    await heapSorter.HeapsortAsync(array);
                    break;

                case 2:
                    QuickSort quickSorter = new QuickSort(UpdateListBox);
                    await quickSorter.QuicksortAsync(array, 0, array.Length - 1);
                    break;

                default:
                    MessageBox.Show("Selecciona un algoritmo válido.");
                    break;
            }
        }

    }
}
