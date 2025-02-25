using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.Errors;
public static class UserErrors
{
    public static readonly Error NotFound = new Error(
        "UserErrors.NotFound", "Can't find user");

    public static readonly Error NotAllowed = new Error(
        "UserErrors.NotAllowed", "Not allowed to access resource");
}

