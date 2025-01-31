﻿using System.ComponentModel.DataAnnotations;

namespace PracticaMVC_2.Models
{
	public class marcas
	{
		[Key]
		[Display(Name = "ID")]
		public int id_marca { get; set; }
		[Display(Name = "Nombre de la marca")]
		public string? nombre_marca { get; set; }
		[Display(Name = "Estado")]
		public string? estados {  get; set; }
	}
}
