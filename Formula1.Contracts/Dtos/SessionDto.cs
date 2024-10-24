namespace Formula1.Contracts.Dtos;

public class SessionDto : SessionBasicDto
{
    public ICollection<ResultDto> Results { get; set; }
}
