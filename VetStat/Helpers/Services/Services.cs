using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;
using VetStat.Models;

namespace VetStat.Helpers.Validators
{
    public static class Services
    {
            //Initial validations
        public static bool PersonValidator(Person person) { 
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"; //Regex for password that is 8 characters long and it contains at least one uppercase letter, one lowercase letter, one digit, and one special character.
            string emailPattern = @"^\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";      //Regex for standard email form

            if (Regex.IsMatch(person.Password, passwordPattern))
                if (Regex.IsMatch(person.Email, emailPattern))
                    if (person.Username.Length >= 5)
                        return true;
                    else throw new Exception("Username must be at least 5 characters long!");
                else throw new Exception("Email format is wrong!");
            else throw new Exception($"Invalid password: {person.Password}");
        }

        public static bool CustomerValidator(Customer customer) //todo -> make interfaces for generic method Validator<T>(T obj) where T : IPerson, ICustomer...
        {
            PersonValidator(customer);
                if (!(customer.MembershipLoyalty > 1 && customer.MembershipLoyalty < 0))
                    return true;
            else throw new Exception("MembershipLoyalty range can be from 0 to 1 (0.0f)");
  
        }

        public static bool AdminValidator(Admin admin)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"; //Regex for password that is 8 characters long and it contains at least one uppercase letter, one lowercase letter, one digit, and one special character.
            if (Regex.IsMatch(admin.Password, passwordPattern))
                return true;
            else throw new Exception("Invalid password");
        }
        //Initial update
        public static void UpdateEntity<T>(T entityToUpdate, T updatedEntity) where T : Person
        { 
            //if updateEntity == null, skip update
            if (!string.IsNullOrEmpty(updatedEntity.FirstName))
                entityToUpdate.FirstName = updatedEntity.FirstName;
            if (!string.IsNullOrEmpty(updatedEntity.LastName))
                entityToUpdate.LastName = updatedEntity.LastName;
            if (!string.IsNullOrEmpty(updatedEntity.Email))
                entityToUpdate.Email = updatedEntity.Email;
            if (!string.IsNullOrEmpty(updatedEntity.Password))
                entityToUpdate.Password = updatedEntity.Password;
            if (!string.IsNullOrEmpty(updatedEntity.Phone))
                entityToUpdate.Phone = updatedEntity.Phone;
            if (updatedEntity.CityId != null)
                entityToUpdate.CityId = updatedEntity.CityId;
            if (!string.IsNullOrEmpty(updatedEntity.Username))
                entityToUpdate.Username = updatedEntity.Username;
            if (updatedEntity.BirthDate != null)
                entityToUpdate.BirthDate = updatedEntity.BirthDate;
            if (updatedEntity.Picture!=null)
                entityToUpdate.Picture = updatedEntity.Picture;
      
            if (entityToUpdate is Vet vet && updatedEntity is Vet updatedVet)
            {
                if (!string.IsNullOrEmpty(updatedVet.Speciality))
                    vet.Speciality = updatedVet.Speciality;
                if (!string.IsNullOrEmpty(updatedVet.SpecialSkill))
                    vet.SpecialSkill = updatedVet.SpecialSkill;
                if (!string.IsNullOrEmpty(updatedVet.Education))
                    vet.Education = updatedVet.Education;
            }

            else if (entityToUpdate is Barber barber && updatedEntity is Barber updatedBarber)
                if (updatedBarber.Certification != null)
                    barber.Certification = updatedBarber.Certification;
                
            if (entityToUpdate is Nurse nurse && updatedEntity is Nurse updatedNurse)
            {
                if (!string.IsNullOrEmpty(updatedNurse.Qualifications))
                    nurse.Qualifications = updatedNurse.Qualifications;

                if (!string.IsNullOrEmpty(updatedNurse.Informations))
                    nurse.Informations = updatedNurse.Informations;
            }
        }
        public static void UpdateEntityCity<T>(T entityToUpdate, T updatedEntity) where T : City
        {
            if (!string.IsNullOrEmpty(updatedEntity.CityName))
                entityToUpdate.CityName = updatedEntity.CityName;
            if (!string.IsNullOrEmpty(updatedEntity.ZipCode))
                entityToUpdate.ZipCode = updatedEntity.ZipCode;
            if (!string.IsNullOrEmpty(updatedEntity.Country))
                entityToUpdate.Country = updatedEntity.Country;
            if (!string.IsNullOrEmpty(updatedEntity.Continent))
                entityToUpdate.Continent = updatedEntity.Continent;
        }


    }
}
