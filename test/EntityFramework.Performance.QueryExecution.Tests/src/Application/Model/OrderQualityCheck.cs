// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace QueryExecution.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DefaultContainerStore.OrderQualityCheck")]
    public partial class OrderQualityCheck
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Required]
        public string CheckedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CheckedDateTime { get; set; }

        public virtual Order Order { get; set; }
    }
}
