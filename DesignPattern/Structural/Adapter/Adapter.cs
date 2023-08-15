using Newtonsoft.Json;
namespace DesignPattern.Structural.Adapter
{
    public class Adapter : ITarget
    {
        private NoteAdaptee noteAdaptee;
        public Adapter(NoteAdaptee noteAdaptee)
        {
            this.noteAdaptee = noteAdaptee;
        }
        public async Task GetDataForNote(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Console.WriteLine(json);
                noteAdaptee.LogTheNote(ConvertFromJson(json));
            }
        }

        public Note ConvertFromJson(string json)
        {
            var note = JsonConvert.DeserializeObject<Note>(json);

            return note;
        }
    }
}
