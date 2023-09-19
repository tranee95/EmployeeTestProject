namespace Employees.Common.ViewModel;

public class EmployeeViewModel
{
    /// <summary>
    /// Идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор отдела.
    /// </summary>
    public Guid DepartmentId { get; set; }

    /// <summary>
    /// Имя.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Фамилия.
    /// </summary>
    public string Surname { get; set; }

    /// <summary>
    /// Отчётство.
    /// </summary>
    public string Patronymic { get; set; }

    /// <summary>
    /// Дата рождения.
    /// </summary>
    public DateTime DateBirth { get; set; }

    /// <summary>
    /// Дата трудоустройства.
    /// </summary>
    public DateTime DateEmployment { get; set; }

    /// <summary>
    /// Зарплата.
    /// </summary>
    public double Salary { get; set; }

    /// <summary>
    /// Флаг удаления.
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Получить ФИО.
    /// </summary>
    /// <returns></returns>
    public string FullName() => $"{Name} {Surname} {Patronymic}";
}
