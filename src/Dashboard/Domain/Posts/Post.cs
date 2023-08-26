using Dashboard.Domain.Base;

namespace Dashboard.Domain.Posts;

/// <summary>
///  �������� ����������.
/// </summary>
public class Post : BaseEntity
{
    /// <summary>
    /// ���������.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// ��������.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// ������������ ���������.
    /// </summary>
    public Guid CategoryId { get; set; }

    /// <summary>
    /// ��������� ����������.
    /// </summary>
    public string Author { get; set; }

    /// <summary>
    /// ������������ �����.
    /// </summary>
    public string TagName { get; set; }

    /// <summary>
    /// ����.
    /// </summary>
    public decimal Price { get; set; }

}