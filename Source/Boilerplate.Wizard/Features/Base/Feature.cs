﻿namespace Boilerplate.Wizard.Features
{
    using System.Threading.Tasks;
    using Boilerplate.Wizard.Services;
    using Framework.ComponentModel;

    public abstract class Feature : NotifyPropertyChanges, IFeature
    {
        private readonly IProjectService projectService;

        public Feature(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        public abstract string Description { get; }

        public abstract string Id { get; }

        public abstract bool IsDefaultSelected { get; }

        public abstract IFeatureGroup Group { get; }

        public abstract int Order { get; }

        public abstract string Title { get; }

        protected IProjectService ProjectService
        {
            get { return this.projectService; }
        }

        public abstract Task AddOrRemoveFeature();
    }
}
