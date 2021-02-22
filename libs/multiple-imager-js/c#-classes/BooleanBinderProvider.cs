    public class BooleanBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Metadata.ModelType == typeof(bool))
                return new BinderTypeModelBinder(typeof(BooleanBinder));
            if (context.Metadata.ModelType == typeof(bool?))
                return new BinderTypeModelBinder(typeof(BooleanBinder));
            return null;
        }
    }
    
    public class BooleanBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            var modelName = bindingContext.ModelName;

            var valueProviderResult =
                bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None)
                return Task.CompletedTask;

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            switch (valueProviderResult.FirstValue)
            {
                case "on":
                case "true":
                    bindingContext.Result = ModelBindingResult.Success(true);
                    break;
                default:
                    bindingContext.Result = ModelBindingResult.Success(false);
                    break;
            }
            return Task.CompletedTask;
        }
    }