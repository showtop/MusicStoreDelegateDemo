namespace MusicStore
{
    public struct Song
    {
        private string title;
        private string artist;
        private string format;

        public string Title { get => title; set => title = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Format { get => format; set => format = value; }
    }
}
