﻿namespace IPSI.Services.Mapping
{
    using AutoMapper;

    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}
