using Microsoft.AspNetCore.Mvc;
using modul9_2211104070.Models;

namespace modul9_2211104070.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // Static list untuk menyimpan data mahasiswa
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa 
            { 
                Name = "John Doe", 
                Nim = "1301204001", 
                Course = new List<string> {"Algoritma", "Database"}, 
                Year = 2023 
            },
            new Mahasiswa 
            { 
                Name = "Jane Smith", 
                Nim = "1301204002", 
                Course = new List<string> {"Web Programming", "Mobile Development"}, 
                Year = 2023 
            },
            new Mahasiswa 
            { 
                Name = "Bob Wilson", 
                Nim = "1301204003", 
                Course = new List<string> {"Machine Learning", "AI"}, 
                Year = 2022 
            }
        };

        // GET: api/Mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAllMahasiswa()
        {
            return Ok(mahasiswaList);
        }

        // GET: api/Mahasiswa/5
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> GetMahasiswa(int id)
        {
            if (id < 0 || id >= mahasiswaList.Count)
            {
                return NotFound();
            }
            return Ok(mahasiswaList[id]);
        }

        // POST: api/Mahasiswa
        [HttpPost]
        public ActionResult<Mahasiswa> PostMahasiswa(Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            return CreatedAtAction(nameof(GetMahasiswa), new { id = mahasiswaList.Count - 1 }, mahasiswa);
        }

        // DELETE: api/Mahasiswa/5
        [HttpDelete("{id}")]
        public IActionResult DeleteMahasiswa(int id)
        {
            if (id < 0 || id >= mahasiswaList.Count)
            {
                return NotFound();
            }
            mahasiswaList.RemoveAt(id);
            return NoContent();
        }
    }
}