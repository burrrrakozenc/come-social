﻿public record CreateSocialEventResponse(
    string Id,
    string Name,
    string SubHeader,
    string Description,
    DateTime? Date,
    List<string> SocialEventTypes,
    List<string> Tags,
    DateTime? CreatedDateTime,
    DateTime? UpdatedDateTime
);

public record SocialEventTypeResponse(
    string Id,
    string Name,
    List<string> SubTypes
);

public enum EventTypes
{
    Concert = 1,
    Theatre = 2,
    Cinema = 3
}
public record TagResponse(
    string Id,
    string Name
    );