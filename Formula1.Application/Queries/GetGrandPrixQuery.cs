﻿using Formula1.Contracts.Dtos;
using MediatR;

namespace Formula1.Application.Queries;

public class GetGrandPrixQuery : IRequest<List<GrandPrixBasicDto>> { }
