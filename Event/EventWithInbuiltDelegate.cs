namespace Test
{
    class EventWithInbuiltDelegate
    {

        public event EventHandler<EventArgs>? ImageCompressed;

        public void Compress(){
            System.Console.WriteLine("Compressing, event using inbuilt delegate");

            onImageCompressed();
        }
        public void Entry(){
            var emailService = new EmailService();

            ImageCompressed += emailService.onImageCompressed!;
            Compress();
        }

        protected virtual void onImageCompressed(){
            if(ImageCompressed != null)
                ImageCompressed(this, EventArgs.Empty);
        }
    }
}