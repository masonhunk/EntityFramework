// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace QueryExecution.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DefaultContainerStore.Computer")]
    public partial class Computer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComputerId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ComputerDetail ComputerDetail { get; set; }
    }
}
