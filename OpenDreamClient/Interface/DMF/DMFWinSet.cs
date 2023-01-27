﻿using JetBrains.Annotations;

namespace OpenDreamClient.Interface.DMF;

public struct DMFWinSet {
    [CanBeNull] public readonly string Element;
    public readonly string Attribute;
    public readonly string Value;

    public DMFWinSet(string element, string attribute, string value) {
        Element = element;
        Attribute = attribute;
        Value = value;
    }
}