namespace Employees.Common.Models;

/// <summary>
/// Отдел.
/// </summary>
public class Department : BaseEntity
{
    /// <summary>
    /// Наименование отдела.
    /// </summary>
    public string Name { get; set; }
}
