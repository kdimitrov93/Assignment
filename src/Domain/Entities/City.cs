﻿namespace Assignment.Domain.Entities;

public class City : BaseAuditableEntity
{
    public string? Name { get; set; }

    public Country? Country { get; set; }
}
