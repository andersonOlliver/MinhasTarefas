namespace MinhasTarefas.Model
{
    public class FacebookProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Picture Picture { get; set; }
       
        public Cover Cover { get; set; }
    }

    public class Picture
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        public bool IsSilhouette { get; set; }
        public string Url { get; set; }
    }

    public class Cover
    {
        public string Id { get; set; }
        public string OffsetY { get; set; }
        public string Source { get; set; }
    }
}
