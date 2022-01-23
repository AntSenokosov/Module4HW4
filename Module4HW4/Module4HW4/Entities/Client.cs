﻿namespace Module4HW4.Entities;

public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<Project> Projects { get; set; } = new List<Project>();
}