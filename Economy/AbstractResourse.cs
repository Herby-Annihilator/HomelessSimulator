using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomelessModel.Common;

namespace HomelessModel
{
    [Serializable]
    public abstract class AbstractResourse
    {
        /// <summary>
        /// Иконка ресурса, может быть это будет просто картинка,
        /// которая будет отображаться на верхней панели ресурсов 
        /// или в специлальном месте или это просто внешний вид ресурса
        /// </summary>
        public virtual Icon ResourseIcon { get; set; }

        /// <summary>
        /// Разрешенные операции с данным ресурсом
        /// </summary>
        public virtual AllowedOperations AllowedOperations { get; protected set; }

        /// <summary>
        /// Конвертирвать данный ресурс в деньги
        /// </summary>
        /// <param name="resourse"></param>
        /// <returns></returns>
       // public abstract double ConvertToMoney(AbstractResourse resourse);

        /// <summary>
        /// Добавить операцию
        /// </summary>
        /// <param name="allowedOperations"></param>
        public virtual void AddAllowedOperation(AllowedOperations allowedOperations)
        {
            AllowedOperations |= allowedOperations;
        }

        /// <summary>
        /// Удалить операцию
        /// </summary>
        /// <param name="allowedOperations"></param>
        public virtual void DeleteAllowedOperations(AllowedOperations allowedOperations)
        {
            AllowedOperations &= allowedOperations;
        }
    }


    /// <summary>
    /// Разрешенные операции над ресурсом
    /// </summary>
    [Flags]
    public enum AllowedOperations : uint
    {
        None = 0x0,   // ничего нельзя
        Create = 0x1,    // его можно созадть (скрафтить)
        Destroy = 0x2,    // его можно разобрать
        ConvertToMoney = 0x4,    // его можно преобразовать в деньги
        ChangeOnSmth = 0x8,

        All = 0xffffffff,
    }
}
