using Dashboard.Contracts.Base;

namespace Dashboard.Contracts.Posts;

/// <summary>
///  ����������.
/// </summary>
public class PostDto : BaseDto
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
    public string CategoryName { get; set; }
    
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