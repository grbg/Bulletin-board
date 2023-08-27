using System;

namespace Dashboard.Dashboard.Contracts.Base;

/// <summary>
/// Базовый контракт.
/// </summary>
public class BaseDto
{
    /// <summary>
    /// Уникальный идентификатор объявления.
    /// </summary>
    public Guid PostId { get; set; }
}
