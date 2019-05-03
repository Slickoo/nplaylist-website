﻿using NPlaylist.Models;
using NPlaylist.Persistence.DbModels;
using NPlaylist.ViewModels;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NPlaylist.Services.AudioService
{
    public interface IAudioService
    {
        Task<Audio> GetAudioAsync(Guid id, CancellationToken ct);
        Task UpdateAudioAsync(Audio audio, CancellationToken ct);
        Task<PaginatedList<AudioEntryViewModel>> GetAudioEntriesRangeAsync(int page, int count, CancellationToken ct);
    }
}
