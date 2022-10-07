namespace Test
{
    class EventWithCustomDelegate
    {
        public delegate void ImageCompressedEventHandler(object source, EventArgs args);

        public event ImageCompressedEventHandler? ImageCompressed;

        public void Compress(){
            System.Console.WriteLine("Compressing, event using custom delegate");

            onImageCompressed();
        }
        public void Entry(){
            var emailService = new EmailService();

            ImageCompressed += emailService.onImageCompressed;
            Compress();
        }

        protected virtual void onImageCompressed(){
            if(ImageCompressed != null)
                ImageCompressed(this, EventArgs.Empty);
        }
    }
}