using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using Vehicles.Common.Enum;

namespace Vehicles.API.Data.Entities
{
    public class User : IdentityUser
    {

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Tipo de documento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DocumentType DocumentType { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public string Address { get; set; }

        [Display(Name = "Foto")]
        public Guid ImageId { get; set; }


        //TODO: Fix the image path
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
    ? $"https://localhost:44363/images/noimage.png"
    : $"https://vehiclessalazar.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "Tipo de Usuario")]
        public UserType UserType { get; set; }

        public string FullName => $"{FirstName}{LastName}";

     
    }
}
