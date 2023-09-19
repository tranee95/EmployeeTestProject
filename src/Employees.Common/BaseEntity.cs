using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Common;

public class BaseEntity
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    /// <summary>
    /// Флаг удаления.
    /// </summary>
    public bool IsDeleted { get; set; }
}
