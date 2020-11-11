using System.ComponentModel;
namespace ProjetoFinalMVC.Models
{
    public class Department
    {
        [DisplayName("ID")]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
