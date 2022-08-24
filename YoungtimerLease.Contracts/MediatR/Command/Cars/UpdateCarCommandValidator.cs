using FluentValidation;

namespace YoungtimerLease.Contracts.MediatR.Command.Cars
{
    public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
    {
        public UpdateCarCommandValidator()
        {
            RuleFor(p => p.NumberOfCilinders).GreaterThan(0);
            RuleFor(p => p.CylinderCapacity).GreaterThan(0);
            RuleFor(p => p.NumberOfGears).GreaterThan(0);
            RuleFor(p => p.CatalogValue).GreaterThan(0);
            RuleFor(p => p.FiscalValue).GreaterThan(0);
            RuleFor(p => p.ReferrenceTariff).GreaterThan(0);
            RuleFor(p => p.Acceleration0To100).GreaterThan(0);
            RuleFor(p => p.TopSpeed).GreaterThan(0);
            RuleFor(p => p.Doors).GreaterThan(0);
            RuleFor(p => p.Mileage).GreaterThan(0);
            RuleFor(p => p.ConstructionDate).LessThanOrEqualTo(DateTime.Today);

        }
    }
}
