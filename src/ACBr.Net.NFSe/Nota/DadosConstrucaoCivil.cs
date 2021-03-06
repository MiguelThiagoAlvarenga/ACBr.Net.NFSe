// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : RFTD
// Created          : 05-26-2016
//
// Last Modified By : RFTD
// Last Modified On : 05-26-2016
// ***********************************************************************
// <copyright file="DadosConstrucaoCivil.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ACBr.Net.Core.Generics;
using PropertyChanged;

namespace ACBr.Net.NFSe.Nota
{
	[ImplementPropertyChanged]
	public sealed class DadosConstrucaoCivil : GenericClone<DadosConstrucaoCivil>
	{
		#region Constructors

		internal DadosConstrucaoCivil()
		{
		}

		#endregion Constructors

		#region Propriedades

		public string CodigoObra { get; set; }

		public string ArtObra { get; set; }

		public string LogradouroObra { get; set; }

		public string ComplementoObra { get; set; }

		public string NumeroObra { get; set; }

		public string BairroObra { get; set; }

		public string CepObra { get; set; }

		public int CodigoMunicipioObra { get; set; }

		public string UFObra { get; set; }

		public int CodigoPaisObra { get; set; }

		public string XPaisObra { get; set; }

		public string CodigoCEI { get; set; }

		public string Projeto { get; set; }

		public string Matricula { get; set; }

		#endregion Propriedades
	}
}