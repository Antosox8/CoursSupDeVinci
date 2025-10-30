﻿using CoursSupDeVinci.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace CoursSupDeVinci;

public class PersonRepository : IPersonRepository
{
    private readonly SchoolDbContext _schoolDbContext;

    public PersonRepository(SchoolDbContext schoolDbContext)
    {
        _schoolDbContext = schoolDbContext;
    }

    public List<Person> GetAllPerson()
    {
        return _schoolDbContext.Persons.ToList();
    }

    public List<Person> GetAllEthan()
    {
        return _schoolDbContext.Persons
            .Include(person => person.Details)
            .Where(person => person.Firstname.Equals("Ethan"))
            .ToList();
    }
}