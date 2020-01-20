using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem.Models
{
    public class Book:BaseEntity
    {
        /// <summary>
        /// 图书名称
        /// </summary>
        [StringLength(100),Required]
        public string BookName { get; set; }
        public decimal Price { get; set; }
    }
}
