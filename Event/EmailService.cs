namespace Test
{
    class EmailService
    {
        public void onImageCompressed(object source, EventArgs args){
            System.Console.WriteLine("Image compressed: Sending mail");
        }
    }
}