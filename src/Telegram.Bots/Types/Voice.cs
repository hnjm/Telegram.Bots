// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright © 2020 Aman Agnihotri

namespace Telegram.Bots.Types
{
  public sealed record Voice : File
  {
    public int Duration { get; init; }

    public string? MimeType { get; init; }
  }
}
