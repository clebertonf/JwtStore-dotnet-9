﻿using System.Text;

namespace JwtStore.Core.SharedContext.Extensions;

public static class StringExtension
{
    public static string ToBase64(this string str)
    {
        return Convert.ToBase64String(Encoding.ASCII.GetBytes(str));
    }
}