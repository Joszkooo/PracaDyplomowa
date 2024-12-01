using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_game.Server.Services.EquipmentService
{
    public interface IEquipmentService
    {
        /* 
            Chcemy umożliwić usuniecie Armora/Broni/Jedzenia i zalozyc/uzyc danej rzeczy
            Aby to zrobic usuwamy dany przedmiot z eq i w przypadku broni/armora wstawiamy nakladany przedmiot w WeaponId/ArmourId
            W przypadku jedzenia dodajemy buff na okreslony czas
        */
        Task<ServiceResponse<Student>> EquipWeapon(GetEquipmentServiceDTO studentItem);
        Task<ServiceResponse<Student>> EquipArmour(GetEquipmentServiceDTO studentItem);
        Task<ServiceResponse<Student>> UseFood(GetEquipmentServiceDTO studentItem);
    }
}