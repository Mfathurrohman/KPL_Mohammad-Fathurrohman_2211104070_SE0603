namespace modul9_[NIM_ANDA].Models
{
    public class Mahasiswa
{
    public string Name { get; set; }
    public string Nim { get; set; }
    public List<string> Course { get; set; }
    public int Year { get; set; }

    public Mahasiswa()
    {
        Course = new List<string>();
    }
}
}