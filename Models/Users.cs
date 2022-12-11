using System.ComponentModel.DataAnnotations;

namespace Projekt2022.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Surname { get; set; }
    [DataType(DataType.Date)]
    public DateTime dateOfBirth { get; set; }
    public string? login { get; set; }  //nullable
    public bool isDeleted { get; set; }

}