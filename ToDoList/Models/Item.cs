using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.JoinEntities = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }

    [Display(Name = "Task Completed")]
    public bool IsCompleted { get; set; } = false;
    public DateTime DateDue { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get; }
  }
}
