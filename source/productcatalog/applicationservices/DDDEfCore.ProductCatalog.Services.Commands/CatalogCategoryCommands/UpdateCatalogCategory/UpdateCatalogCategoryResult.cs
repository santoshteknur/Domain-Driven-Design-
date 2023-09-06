﻿using DDDEfCore.ProductCatalog.Core.DomainModels.Catalogs;

namespace DDDEfCore.ProductCatalog.Services.Commands.CatalogCategoryCommands.UpdateCatalogCategory;
public class UpdateCatalogCategoryResult
{
    public CatalogId CatalogId { get; init; }
    public CatalogCategoryId CatalogCategoryId { get; init; }

    public static UpdateCatalogCategoryResult Instance(UpdateCatalogCategoryCommand command)
        => new()
        {
            CatalogId = command.CatalogId,
            CatalogCategoryId = command.CatalogCategoryId
        };
}