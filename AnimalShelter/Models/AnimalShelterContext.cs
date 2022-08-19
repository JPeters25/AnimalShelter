using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base(options)
      { 
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Henry", Species = "Dog", Age = 2, Gender = "Male", Breed = "Mini-Daschund"},
          new Animal { AnimalId = 2, Name = "Ellie", Species = "Dog", Age = 1, Gender = "Female", Breed = "Mini-Daschund"},
          new Animal { AnimalId = 3, Name = "Cooper", Species = "Dog", Age = 14, Gender = "Male", Breed = "Beagle Bassett Hound"},
          new Animal { AnimalId = 4, Name = "Sofie", Species = "Cat", Age = 4, Gender = "Female", Breed = "Tuxedo"},
          new Animal { AnimalId = 5, Name = "Maverick", Species = "Cat", Age = 3, Gender = "Male", Breed = "American Shorthair"},
          new Animal { AnimalId = 6, Name = "George", Species = "Dog", Age = 5, Gender = "Male", Breed = "Black Lab"},
          new Animal { AnimalId = 7, Name = "Feida", Species = "Dog", Age = 7, Gender = "Female", Breed = "Pomeranian"},
          new Animal { AnimalId = 8, Name = "Lucy", Species = "Dog", Age = 6, Gender = "Female", Breed = "Cocker Spaniel"},
          new Animal { AnimalId = 9, Name = "Sally", Species = "Dog", Age = 3, Gender = "Female", Breed = "Golden Retriever"},
          new Animal { AnimalId = 10, Name = "Charlie", Species = "Dog", Age = 8, Gender = "Male", Breed = "Bulldog"},
          new Animal { AnimalId = 11, Name = "Linus", Species = "Dog", Age = 2, Gender = "Male", Breed = "Golden Doodle"},
          new Animal { AnimalId = 12, Name = "Boots", Species = "Cat", Age = 4, Gender = "Male", Breed = "Munchkin"},
          new Animal { AnimalId = 13, Name = "Maire", Species = "Cat", Age = 3, Gender = "Female", Breed = "Persian"}
        );
      }

      public DbSet<Animal> Animals { get; set; }
  }
}