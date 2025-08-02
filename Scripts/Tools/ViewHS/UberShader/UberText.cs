using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
//using Hearthstone.Core.Jobs;
//using Hearthstone.UI;
//using Hearthstone.UI.Internal;
using UnityEngine;

// Token: 0x02000A0F RID: 2575
//[ExecuteAlways]
//[CustomEditClass]
public class UberText : MonoBehaviour//, IPopupRendering
{
	/*
	// Token: 0x060087AD RID: 34733 RVA: 0x002C88E0 File Offset: 0x002C6AE0
	public static UberText[] EnableAllTextInObject(GameObject obj, bool enable)
	{
		UberText[] componentsInChildren = obj.GetComponentsInChildren<UberText>();
		UberText.EnableAllTextObjects(componentsInChildren, enable);
		return componentsInChildren;
	}

	// Token: 0x060087AE RID: 34734 RVA: 0x002C88F0 File Offset: 0x002C6AF0
	public static void EnableAllTextObjects(UberText[] objs, bool enable)
	{
		for (int i = 0; i < objs.Length; i++)
		{
			objs[i].gameObject.SetActive(enable);
		}
	}

	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x060087AF RID: 34735 RVA: 0x002C891B File Offset: 0x002C6B1B
	private bool IsPartOfWidget
	{
		get
		{
			return this.m_widgetTransform != null;
		}
	}

	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x060087B0 RID: 34736 RVA: 0x002C8929 File Offset: 0x002C6B29
	protected float Offset
	{
		get
		{
			if (this.m_Offset == 0f)
			{
				UberText.s_offset -= 100f;
				this.m_Offset = UberText.s_offset;
			}
			return this.m_Offset;
		}
	}

	// Token: 0x170007CE RID: 1998
	// (get) Token: 0x060087B1 RID: 34737 RVA: 0x002C8959 File Offset: 0x002C6B59
	// (set) Token: 0x060087B2 RID: 34738 RVA: 0x002C8964 File Offset: 0x002C6B64
	[Overridable]
	[CustomEditField(Sections = "Text", T = EditType.TEXT_AREA)]
	public string Text
	{
		get
		{
			return this.m_Text;
		}
		set
		{
			this.m_TextSet = true;
			this.m_TextSet = true;
			if (value == this.m_Text)
			{
				return;
			}
			this.m_Text = (value ?? string.Empty);
			if (this.m_Text.Any((char c) => char.IsSurrogate(c)))
			{
				IEnumerable<char> source = (from c in this.m_Text
				where !char.IsLowSurrogate(c)
				select c).Select(delegate(char c)
				{
					if (!char.IsHighSurrogate(c))
					{
						return c;
					}
					return '�';
				});
				this.m_Text = new string(source.ToArray<char>());
			}
			if (this.m_Text == this.m_PreviousText)
			{
				return;
			}
			this.UpdateNow(false);
		}
	}

	// Token: 0x170007CF RID: 1999
	// (get) Token: 0x060087B3 RID: 34739 RVA: 0x002C8A45 File Offset: 0x002C6C45
	// (set) Token: 0x060087B4 RID: 34740 RVA: 0x002C8A4D File Offset: 0x002C6C4D
	[CustomEditField(Sections = "Text", HidePredicate = "IsPartOfWidget")]
	public bool GameStringLookup
	{
		get
		{
			return this.m_GameStringLookup;
		}
		set
		{
			if (value == this.m_GameStringLookup)
			{
				return;
			}
			this.m_GameStringLookup = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007D0 RID: 2000
	// (get) Token: 0x060087B5 RID: 34741 RVA: 0x002C8A66 File Offset: 0x002C6C66
	// (set) Token: 0x060087B6 RID: 34742 RVA: 0x002C8A6E File Offset: 0x002C6C6E
	[CustomEditField(Sections = "Text", HidePredicate = "IsPartOfWidget")]
	public bool UseEditorText
	{
		get
		{
			return this.m_UseEditorText;
		}
		set
		{
			if (value == this.m_UseEditorText)
			{
				return;
			}
			this.m_UseEditorText = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007D1 RID: 2001
	// (get) Token: 0x060087B7 RID: 34743 RVA: 0x002C8A87 File Offset: 0x002C6C87
	// (set) Token: 0x060087B8 RID: 34744 RVA: 0x002C8A8F File Offset: 0x002C6C8F
	[CustomEditField(Sections = "Text", HidePredicate = "IsPartOfWidget")]
	public bool Cache
	{
		get
		{
			return this.m_Cache;
		}
		set
		{
			this.m_Cache = value;
		}
	}

	// Token: 0x170007D2 RID: 2002
	// (get) Token: 0x060087B9 RID: 34745 RVA: 0x002C8A98 File Offset: 0x002C6C98
	// (set) Token: 0x060087BA RID: 34746 RVA: 0x002C8AA0 File Offset: 0x002C6CA0
	[CustomEditField(Sections = "Size", HidePredicate = "IsPartOfWidget")]
	public float Width
	{
		get
		{
			return this.m_Width;
		}
		set
		{
			if (value == this.m_Width)
			{
				return;
			}
			this.m_Width = value;
			if (this.m_Width < 0.01f)
			{
				this.m_Width = 0.01f;
			}
			this.UpdateText();
		}
	}

	// Token: 0x170007D3 RID: 2003
	// (get) Token: 0x060087BB RID: 34747 RVA: 0x002C8AD1 File Offset: 0x002C6CD1
	// (set) Token: 0x060087BC RID: 34748 RVA: 0x002C8AD9 File Offset: 0x002C6CD9
	[CustomEditField(Sections = "Size", HidePredicate = "IsPartOfWidget")]
	public float Height
	{
		get
		{
			return this.m_Height;
		}
		set
		{
			if (value == this.m_Height)
			{
				return;
			}
			this.m_Height = value;
			if (this.m_Height < 0.01f)
			{
				this.m_Height = 0.01f;
			}
			this.UpdateText();
		}
	}

	// Token: 0x170007D4 RID: 2004
	// (get) Token: 0x060087BD RID: 34749 RVA: 0x002C8B0A File Offset: 0x002C6D0A
	// (set) Token: 0x060087BE RID: 34750 RVA: 0x002C8B12 File Offset: 0x002C6D12
	[CustomEditField(Sections = "Size")]
	public float LineSpacing
	{
		get
		{
			return this.m_LineSpacing;
		}
		set
		{
			if (value == this.m_LineSpacing)
			{
				return;
			}
			this.m_LineSpacing = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007D5 RID: 2005
	// (get) Token: 0x060087BF RID: 34751 RVA: 0x002C8B2B File Offset: 0x002C6D2B
	// (set) Token: 0x060087C0 RID: 34752 RVA: 0x002C8B33 File Offset: 0x002C6D33
	[CustomEditField(Sections = "Style")]
	public Font TrueTypeFont
	{
		get
		{
			return this.m_Font;
		}
		set
		{
			if (value == this.m_Font)
			{
				return;
			}
			this.m_Font = value;
			this.m_isFontDefLoaded = false;
			this.SetFont();
			this.UpdateText();
		}
	}

	// Token: 0x170007D6 RID: 2006
	// (get) Token: 0x060087C1 RID: 34753 RVA: 0x002C8B5E File Offset: 0x002C6D5E
	// (set) Token: 0x060087C2 RID: 34754 RVA: 0x002C8B66 File Offset: 0x002C6D66
	[CustomEditField(Sections = "Style")]
	public int FontSize
	{
		get
		{
			return this.m_FontSize;
		}
		set
		{
			if (value == this.m_FontSize)
			{
				return;
			}
			this.m_FontSize = value;
			if (this.m_FontSize < 1)
			{
				this.m_FontSize = 1;
			}
			if (this.m_FontSize > 120)
			{
				this.m_FontSize = 120;
			}
			this.UpdateText();
		}
	}

	// Token: 0x170007D7 RID: 2007
	// (get) Token: 0x060087C3 RID: 34755 RVA: 0x002C8BA1 File Offset: 0x002C6DA1
	// (set) Token: 0x060087C4 RID: 34756 RVA: 0x002C8BAC File Offset: 0x002C6DAC
	[CustomEditField(Sections = "Style")]
	public int MinFontSize
	{
		get
		{
			return this.m_MinFontSize;
		}
		set
		{
			if (value == this.m_MinFontSize)
			{
				return;
			}
			this.m_MinFontSize = value;
			if (this.m_MinFontSize < 1)
			{
				this.m_MinFontSize = 1;
			}
			if (this.m_MinFontSize > this.m_FontSize)
			{
				this.m_MinFontSize = this.m_FontSize;
			}
			this.UpdateText();
		}
	}

	// Token: 0x170007D8 RID: 2008
	// (get) Token: 0x060087C5 RID: 34757 RVA: 0x002C8BFA File Offset: 0x002C6DFA
	// (set) Token: 0x060087C6 RID: 34758 RVA: 0x002C8C02 File Offset: 0x002C6E02
	[Overridable]
	[CustomEditField(Sections = "Style")]
	public float CharacterSize
	{
		get
		{
			return this.m_CharacterSize;
		}
		set
		{
			if (value == this.m_CharacterSize)
			{
				return;
			}
			this.m_CharacterSize = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007D9 RID: 2009
	// (get) Token: 0x060087C7 RID: 34759 RVA: 0x002C8C1B File Offset: 0x002C6E1B
	// (set) Token: 0x060087C8 RID: 34760 RVA: 0x002C8C24 File Offset: 0x002C6E24
	[CustomEditField(Sections = "Style")]
	public float MinCharacterSize
	{
		get
		{
			return this.m_MinCharacterSize;
		}
		set
		{
			if (value == this.m_MinCharacterSize)
			{
				return;
			}
			this.m_MinCharacterSize = value;
			if (this.m_MinCharacterSize < 0.001f)
			{
				this.m_MinCharacterSize = 0.001f;
			}
			if (this.m_MinCharacterSize > this.m_CharacterSize)
			{
				this.m_MinCharacterSize = this.m_CharacterSize;
			}
			this.UpdateText();
		}
	}

	// Token: 0x170007DA RID: 2010
	// (get) Token: 0x060087C9 RID: 34761 RVA: 0x002C8C7A File Offset: 0x002C6E7A
	// (set) Token: 0x060087CA RID: 34762 RVA: 0x002C8C82 File Offset: 0x002C6E82
	[CustomEditField(Sections = "Style")]
	public bool RichText
	{
		get
		{
			return this.m_RichText;
		}
		set
		{
			if (value == this.m_RichText)
			{
				return;
			}
			this.m_RichText = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007DB RID: 2011
	// (get) Token: 0x060087CB RID: 34763 RVA: 0x002C8C9B File Offset: 0x002C6E9B
	// (set) Token: 0x060087CC RID: 34764 RVA: 0x002C8CA3 File Offset: 0x002C6EA3
	[Overridable]
	[CustomEditField(Sections = "Style")]
	public Color TextColor
	{
		get
		{
			return this.m_TextColor;
		}
		set
		{
			if (value == this.m_TextColor)
			{
				return;
			}
			this.m_TextColor = value;
			this.UpdateColor();
		}
	}

	// Token: 0x170007DC RID: 2012
	// (get) Token: 0x060087CD RID: 34765 RVA: 0x002C8CC1 File Offset: 0x002C6EC1
	// (set) Token: 0x060087CE RID: 34766 RVA: 0x002C8CCE File Offset: 0x002C6ECE
	[Overridable]
	[CustomEditField(Hide = true)]
	public float TextAlpha
	{
		get
		{
			return this.m_TextColor.a;
		}
		set
		{
			if (value == this.m_TextColor.a)
			{
				return;
			}
			this.m_TextColor.a = value;
			this.UpdateColor();
		}
	}

	// Token: 0x170007DD RID: 2013
	// (get) Token: 0x060087CF RID: 34767 RVA: 0x002C8CF1 File Offset: 0x002C6EF1
	// (set) Token: 0x060087D0 RID: 34768 RVA: 0x002C8CF9 File Offset: 0x002C6EF9
	[CustomEditField(Sections = "Style")]
	public float BoldSize
	{
		get
		{
			return this.m_BoldSize;
		}
		set
		{
			if (value == this.m_BoldSize)
			{
				return;
			}
			this.m_BoldSize = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007DE RID: 2014
	// (get) Token: 0x060087D1 RID: 34769 RVA: 0x002C8D12 File Offset: 0x002C6F12
	// (set) Token: 0x060087D2 RID: 34770 RVA: 0x002C8D1A File Offset: 0x002C6F1A
	[CustomEditField(Sections = "Paragraph")]
	public bool WordWrap
	{
		get
		{
			return this.m_WordWrap;
		}
		set
		{
			if (value == this.m_WordWrap)
			{
				return;
			}
			this.m_WordWrap = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007DF RID: 2015
	// (get) Token: 0x060087D3 RID: 34771 RVA: 0x002C8D33 File Offset: 0x002C6F33
	// (set) Token: 0x060087D4 RID: 34772 RVA: 0x002C8D3B File Offset: 0x002C6F3B
	[CustomEditField(Sections = "Paragraph")]
	public bool ForceWrapLargeWords
	{
		get
		{
			return this.m_ForceWrapLargeWords;
		}
		set
		{
			if (value == this.m_ForceWrapLargeWords)
			{
				return;
			}
			this.m_ForceWrapLargeWords = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E0 RID: 2016
	// (get) Token: 0x060087D5 RID: 34773 RVA: 0x002C8D54 File Offset: 0x002C6F54
	// (set) Token: 0x060087D6 RID: 34774 RVA: 0x002C8D5C File Offset: 0x002C6F5C
	[CustomEditField(Sections = "Paragraph")]
	public bool ResizeToFit
	{
		get
		{
			return this.m_ResizeToFit;
		}
		set
		{
			if (value == this.m_ResizeToFit)
			{
				return;
			}
			this.m_ResizeToFit = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E1 RID: 2017
	// (get) Token: 0x060087D7 RID: 34775 RVA: 0x002C8D75 File Offset: 0x002C6F75
	// (set) Token: 0x060087D8 RID: 34776 RVA: 0x002C8D7D File Offset: 0x002C6F7D
	[CustomEditField(Sections = "Paragraph")]
	public bool ResizeToFitAndGrow
	{
		get
		{
			return this.m_ResizeToFitAndGrow;
		}
		set
		{
			if (value == this.m_ResizeToFitAndGrow)
			{
				return;
			}
			this.m_ResizeToFitAndGrow = value;
			this.m_ResizeToFit = (this.m_ResizeToFit || value);
			this.UpdateText();
		}
	}

	// Token: 0x170007E2 RID: 2018
	// (get) Token: 0x060087D9 RID: 34777 RVA: 0x002C8DA4 File Offset: 0x002C6FA4
	// (set) Token: 0x060087DA RID: 34778 RVA: 0x002C8DAC File Offset: 0x002C6FAC
	[CustomEditField(Sections = "Paragraph")]
	public float ResizeToGrowStep
	{
		get
		{
			return this.m_ResizeToGrowStep;
		}
		set
		{
			if (value == this.m_ResizeToGrowStep)
			{
				return;
			}
			this.m_ResizeToGrowStep = Math.Max(0.01f, value);
			this.UpdateText();
		}
	}

	// Token: 0x170007E3 RID: 2019
	// (get) Token: 0x060087DB RID: 34779 RVA: 0x002C8DCF File Offset: 0x002C6FCF
	// (set) Token: 0x060087DC RID: 34780 RVA: 0x002C8DD7 File Offset: 0x002C6FD7
	[CustomEditField(Sections = "Underwear", Label = "Enable")]
	public bool Underwear
	{
		get
		{
			return this.m_Underwear;
		}
		set
		{
			if (value == this.m_Underwear)
			{
				return;
			}
			this.m_Underwear = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E4 RID: 2020
	// (get) Token: 0x060087DD RID: 34781 RVA: 0x002C8DF0 File Offset: 0x002C6FF0
	// (set) Token: 0x060087DE RID: 34782 RVA: 0x002C8DF8 File Offset: 0x002C6FF8
	[CustomEditField(Parent = "Underwear", Label = "Flip")]
	public bool UnderwearFlip
	{
		get
		{
			return this.m_UnderwearFlip;
		}
		set
		{
			if (value == this.m_UnderwearFlip)
			{
				return;
			}
			this.m_UnderwearFlip = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E5 RID: 2021
	// (get) Token: 0x060087DF RID: 34783 RVA: 0x002C8E11 File Offset: 0x002C7011
	// (set) Token: 0x060087E0 RID: 34784 RVA: 0x002C8E19 File Offset: 0x002C7019
	[CustomEditField(Parent = "Underwear", Label = "Width")]
	public float UnderwearWidth
	{
		get
		{
			return this.m_UnderwearWidth;
		}
		set
		{
			if (value == this.m_UnderwearWidth)
			{
				return;
			}
			this.m_UnderwearWidth = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E6 RID: 2022
	// (get) Token: 0x060087E1 RID: 34785 RVA: 0x002C8E32 File Offset: 0x002C7032
	// (set) Token: 0x060087E2 RID: 34786 RVA: 0x002C8E3A File Offset: 0x002C703A
	[CustomEditField(Parent = "Underwear", Label = "Height")]
	public float UnderwearHeight
	{
		get
		{
			return this.m_UnderwearHeight;
		}
		set
		{
			if (value == this.m_UnderwearHeight)
			{
				return;
			}
			this.m_UnderwearHeight = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E7 RID: 2023
	// (get) Token: 0x060087E3 RID: 34787 RVA: 0x002C8E53 File Offset: 0x002C7053
	// (set) Token: 0x060087E4 RID: 34788 RVA: 0x002C8E5B File Offset: 0x002C705B
	[CustomEditField(Sections = "Alignment", Label = "Enable")]
	[Overridable]
	public UberText.AlignmentOptions Alignment
	{
		get
		{
			return this.m_Alignment;
		}
		set
		{
			if (value == this.m_Alignment)
			{
				return;
			}
			this.m_Alignment = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E8 RID: 2024
	// (get) Token: 0x060087E5 RID: 34789 RVA: 0x002C8E74 File Offset: 0x002C7074
	// (set) Token: 0x060087E6 RID: 34790 RVA: 0x002C8E7C File Offset: 0x002C707C
	[CustomEditField(Parent = "Alignment")]
	[Overridable]
	public UberText.AnchorOptions Anchor
	{
		get
		{
			return this.m_Anchor;
		}
		set
		{
			if (value == this.m_Anchor)
			{
				return;
			}
			this.m_Anchor = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007E9 RID: 2025
	// (get) Token: 0x060087E7 RID: 34791 RVA: 0x002C8E95 File Offset: 0x002C7095
	// (set) Token: 0x060087E8 RID: 34792 RVA: 0x002C8E9D File Offset: 0x002C709D
	[CustomEditField(Sections = "Render/Bake")]
	public bool RenderToTexture
	{
		get
		{
			return this.m_RenderToTexture;
		}
		set
		{
			if (value == this.m_RenderToTexture)
			{
				return;
			}
			this.m_RenderToTexture = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007EA RID: 2026
	// (get) Token: 0x060087E9 RID: 34793 RVA: 0x002C8EB6 File Offset: 0x002C70B6
	// (set) Token: 0x060087EA RID: 34794 RVA: 0x002C8EBE File Offset: 0x002C70BE
	[CustomEditField(Sections = "Render/Bake")]
	public GameObject RenderOnObject
	{
		get
		{
			return this.m_RenderOnObject;
		}
		set
		{
			if (value == this.m_RenderOnObject)
			{
				return;
			}
			this.m_RenderOnObject = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007EB RID: 2027
	// (get) Token: 0x060087EB RID: 34795 RVA: 0x002C8EDC File Offset: 0x002C70DC
	// (set) Token: 0x060087EC RID: 34796 RVA: 0x002C8EE4 File Offset: 0x002C70E4
	[CustomEditField(Parent = "RenderToTexture")]
	public int TextureResolution
	{
		get
		{
			return this.m_Resolution;
		}
		set
		{
			if (value == this.m_Resolution)
			{
				return;
			}
			this.m_Resolution = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007EC RID: 2028
	// (get) Token: 0x060087ED RID: 34797 RVA: 0x002C8EFD File Offset: 0x002C70FD
	// (set) Token: 0x060087EE RID: 34798 RVA: 0x002C8F05 File Offset: 0x002C7105
	[CustomEditField(Sections = "Outline", Label = "Enable")]
	[Overridable]
	public bool Outline
	{
		get
		{
			return this.m_Outline;
		}
		set
		{
			if (value == this.m_Outline)
			{
				return;
			}
			this.m_Outline = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007ED RID: 2029
	// (get) Token: 0x060087EF RID: 34799 RVA: 0x002C8F1E File Offset: 0x002C711E
	// (set) Token: 0x060087F0 RID: 34800 RVA: 0x002C8F26 File Offset: 0x002C7126
	[CustomEditField(Parent = "Outline", Label = "Size")]
	[Overridable]
	public float OutlineSize
	{
		get
		{
			return this.m_OutlineSize;
		}
		set
		{
			if (value == this.m_OutlineSize)
			{
				return;
			}
			this.m_OutlineSize = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007EE RID: 2030
	// (get) Token: 0x060087F1 RID: 34801 RVA: 0x002C8F3F File Offset: 0x002C713F
	// (set) Token: 0x060087F2 RID: 34802 RVA: 0x002C8F47 File Offset: 0x002C7147
	[CustomEditField(Parent = "Outline", Label = "Color")]
	[Overridable]
	public Color OutlineColor
	{
		get
		{
			return this.m_OutlineColor;
		}
		set
		{
			if (value == this.m_OutlineColor)
			{
				return;
			}
			this.m_OutlineColor = value;
			this.UpdateColor();
		}
	}

	// Token: 0x170007EF RID: 2031
	// (get) Token: 0x060087F3 RID: 34803 RVA: 0x002C8F65 File Offset: 0x002C7165
	// (set) Token: 0x060087F4 RID: 34804 RVA: 0x002C8F72 File Offset: 0x002C7172
	[CustomEditField(Hide = true)]
	[Overridable]
	public float OutlineAlpha
	{
		get
		{
			return this.m_OutlineColor.a;
		}
		set
		{
			if (value == this.m_OutlineColor.a)
			{
				return;
			}
			this.m_OutlineColor.a = value;
			this.UpdateColor();
		}
	}

	// Token: 0x170007F0 RID: 2032
	// (get) Token: 0x060087F5 RID: 34805 RVA: 0x002C8F95 File Offset: 0x002C7195
	// (set) Token: 0x060087F6 RID: 34806 RVA: 0x002C8F9D File Offset: 0x002C719D
	[CustomEditField(Parent = "RenderToTexture")]
	public bool AntiAlias
	{
		get
		{
			return this.m_AntiAlias;
		}
		set
		{
			if (value == this.m_AntiAlias)
			{
				return;
			}
			this.m_AntiAlias = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F1 RID: 2033
	// (get) Token: 0x060087F7 RID: 34807 RVA: 0x002C8FB6 File Offset: 0x002C71B6
	// (set) Token: 0x060087F8 RID: 34808 RVA: 0x002C8FBE File Offset: 0x002C71BE
	[CustomEditField(Parent = "AntiAlias")]
	public float AntiAliasAmount
	{
		get
		{
			return this.m_AntiAliasAmount;
		}
		set
		{
			if (value == this.m_AntiAliasAmount)
			{
				return;
			}
			this.m_AntiAliasAmount = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x060087F9 RID: 34809 RVA: 0x002C8FD7 File Offset: 0x002C71D7
	// (set) Token: 0x060087FA RID: 34810 RVA: 0x002C8FDF File Offset: 0x002C71DF
	[CustomEditField(Sections = "Localization")]
	public UberText.LocalizationSettings LocalizeSettings
	{
		get
		{
			return this.m_LocalizedSettings;
		}
		set
		{
			this.m_LocalizedSettings = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F3 RID: 2035
	// (get) Token: 0x060087FB RID: 34811 RVA: 0x002C8FEE File Offset: 0x002C71EE
	// (set) Token: 0x060087FC RID: 34812 RVA: 0x002C8FF6 File Offset: 0x002C71F6
	[CustomEditField(Parent = "AntiAlias")]
	public float AntiAliasEdge
	{
		get
		{
			return this.m_AntiAliasEdge;
		}
		set
		{
			if (value == this.m_AntiAliasEdge)
			{
				return;
			}
			this.m_AntiAliasEdge = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F4 RID: 2036
	// (get) Token: 0x060087FD RID: 34813 RVA: 0x002C900F File Offset: 0x002C720F
	// (set) Token: 0x060087FE RID: 34814 RVA: 0x002C9017 File Offset: 0x002C7217
	[CustomEditField(Sections = "Shadow", Label = "Enable")]
	[Overridable]
	public bool Shadow
	{
		get
		{
			return this.m_Shadow;
		}
		set
		{
			if (value == this.m_Shadow)
			{
				return;
			}
			this.m_Shadow = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F5 RID: 2037
	// (get) Token: 0x060087FF RID: 34815 RVA: 0x002C9030 File Offset: 0x002C7230
	// (set) Token: 0x06008800 RID: 34816 RVA: 0x002C9038 File Offset: 0x002C7238
	[CustomEditField(Parent = "Shadow")]
	[Overridable]
	public float ShadowOffset
	{
		get
		{
			return this.m_ShadowOffset;
		}
		set
		{
			if (value == this.m_ShadowOffset)
			{
				return;
			}
			this.m_ShadowOffset = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x06008801 RID: 34817 RVA: 0x002C9051 File Offset: 0x002C7251
	// (set) Token: 0x06008802 RID: 34818 RVA: 0x002C9059 File Offset: 0x002C7259
	[CustomEditField(Parent = "Shadow")]
	[Overridable]
	public float ShadowDepthOffset
	{
		get
		{
			return this.m_ShadowDepthOffset;
		}
		set
		{
			if (value == this.m_ShadowDepthOffset)
			{
				return;
			}
			this.m_ShadowDepthOffset = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x06008803 RID: 34819 RVA: 0x002C9072 File Offset: 0x002C7272
	// (set) Token: 0x06008804 RID: 34820 RVA: 0x002C907A File Offset: 0x002C727A
	[CustomEditField(Parent = "Shadow")]
	[Overridable]
	public float ShadowBlur
	{
		get
		{
			return this.m_ShadowBlur;
		}
		set
		{
			if (value == this.m_ShadowBlur)
			{
				return;
			}
			this.m_ShadowBlur = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007F8 RID: 2040
	// (get) Token: 0x06008805 RID: 34821 RVA: 0x002C9093 File Offset: 0x002C7293
	// (set) Token: 0x06008806 RID: 34822 RVA: 0x002C909B File Offset: 0x002C729B
	[CustomEditField(Parent = "Shadow")]
	[Overridable]
	public Color ShadowColor
	{
		get
		{
			return this.m_ShadowColor;
		}
		set
		{
			if (value == this.m_ShadowColor)
			{
				return;
			}
			this.m_ShadowColor = value;
			this.UpdateColor();
		}
	}

	// Token: 0x170007F9 RID: 2041
	// (get) Token: 0x06008807 RID: 34823 RVA: 0x002C90B9 File Offset: 0x002C72B9
	// (set) Token: 0x06008808 RID: 34824 RVA: 0x002C90C6 File Offset: 0x002C72C6
	[CustomEditField(Parent = "Shadow")]
	[Overridable]
	public float ShadowAlpha
	{
		get
		{
			return this.m_ShadowColor.a;
		}
		set
		{
			if (value == this.m_ShadowColor.a)
			{
				return;
			}
			this.m_ShadowColor.a = value;
			this.UpdateColor();
		}
	}

	// Token: 0x170007FA RID: 2042
	// (get) Token: 0x06008809 RID: 34825 RVA: 0x002C90E9 File Offset: 0x002C72E9
	// (set) Token: 0x0600880A RID: 34826 RVA: 0x002C90F1 File Offset: 0x002C72F1
	[CustomEditField(Parent = "Shadow")]
	public int ShadowRenderQueueOffset
	{
		get
		{
			return this.m_ShadowRenderQueueOffset;
		}
		set
		{
			if (value == this.m_ShadowRenderQueueOffset)
			{
				return;
			}
			this.m_ShadowRenderQueueOffset = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007FB RID: 2043
	// (get) Token: 0x0600880B RID: 34827 RVA: 0x002C910A File Offset: 0x002C730A
	// (set) Token: 0x0600880C RID: 34828 RVA: 0x002C9112 File Offset: 0x002C7312
	[CustomEditField(Sections = "Render")]
	public int RenderQueue
	{
		get
		{
			return this.m_RenderQueue;
		}
		set
		{
			if (value == this.m_RenderQueue)
			{
				return;
			}
			this.m_RenderQueue = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007FC RID: 2044
	// (get) Token: 0x0600880D RID: 34829 RVA: 0x002C912B File Offset: 0x002C732B
	// (set) Token: 0x0600880E RID: 34830 RVA: 0x002C9133 File Offset: 0x002C7333
	[CustomEditField(Sections = "Render")]
	public float AmbientLightBlend
	{
		get
		{
			return this.m_AmbientLightBlend;
		}
		set
		{
			if (value == this.m_AmbientLightBlend)
			{
				return;
			}
			this.m_AmbientLightBlend = value;
			this.UpdateText();
		}
	}

	// Token: 0x170007FD RID: 2045
	// (get) Token: 0x0600880F RID: 34831 RVA: 0x002C914C File Offset: 0x002C734C
	// (set) Token: 0x06008810 RID: 34832 RVA: 0x002C9154 File Offset: 0x002C7354
	[CustomEditField(Sections = "Render")]
	public List<Material> AdditionalMaterials
	{
		get
		{
			return this.m_AdditionalMaterials;
		}
		set
		{
			this.m_AdditionalMaterials = value;
		}
	}

	// Token: 0x170007FE RID: 2046
	// (get) Token: 0x06008811 RID: 34833 RVA: 0x002C915D File Offset: 0x002C735D
	// (set) Token: 0x06008812 RID: 34834 RVA: 0x002C9165 File Offset: 0x002C7365
	[CustomEditField(Parent = "RenderToTexture")]
	public Color GradientUpperColor
	{
		get
		{
			return this.m_GradientUpperColor;
		}
		set
		{
			if (value == this.m_GradientUpperColor)
			{
				return;
			}
			this.m_GradientUpperColor = value;
			this.UpdateColor();
		}
	}

	// Token: 0x170007FF RID: 2047
	// (get) Token: 0x06008813 RID: 34835 RVA: 0x002C9183 File Offset: 0x002C7383
	// (set) Token: 0x06008814 RID: 34836 RVA: 0x002C9190 File Offset: 0x002C7390
	[CustomEditField(Hide = true)]
	public float GradientUpperAlpha
	{
		get
		{
			return this.m_GradientUpperColor.a;
		}
		set
		{
			if (value == this.m_GradientUpperColor.a)
			{
				return;
			}
			this.m_GradientUpperColor.a = value;
			this.UpdateColor();
		}
	}

	// Token: 0x17000800 RID: 2048
	// (get) Token: 0x06008815 RID: 34837 RVA: 0x002C91B3 File Offset: 0x002C73B3
	// (set) Token: 0x06008816 RID: 34838 RVA: 0x002C91BB File Offset: 0x002C73BB
	[CustomEditField(Parent = "RenderToTexture")]
	public Color GradientLowerColor
	{
		get
		{
			return this.m_GradientLowerColor;
		}
		set
		{
			if (value == this.m_GradientLowerColor)
			{
				return;
			}
			this.m_GradientLowerColor = value;
			this.UpdateColor();
		}
	}

	// Token: 0x17000801 RID: 2049
	// (get) Token: 0x06008817 RID: 34839 RVA: 0x002C91D9 File Offset: 0x002C73D9
	// (set) Token: 0x06008818 RID: 34840 RVA: 0x002C91E6 File Offset: 0x002C73E6
	[CustomEditField(Hide = true)]
	public float GradientLowerAlpha
	{
		get
		{
			return this.m_GradientLowerColor.a;
		}
		set
		{
			if (value == this.m_GradientLowerColor.a)
			{
				return;
			}
			this.m_GradientLowerColor.a = value;
			this.UpdateColor();
		}
	}

	// Token: 0x17000802 RID: 2050
	// (get) Token: 0x06008819 RID: 34841 RVA: 0x002C9209 File Offset: 0x002C7409
	public bool IsMeshReady
	{
		get
		{
			return this.m_meshReadyTracker.IsSet;
		}
	}

	// Token: 0x0600881A RID: 34842 RVA: 0x002C9218 File Offset: 0x002C7418
	private void Awake()
	{
		this.m_UberTextRendering = new UberTextRendering();
		this.m_UberTextRenderToTexture = new UberTextRenderToTexture();
		this.m_widgetTransform = base.GetComponent<WidgetTransform>();
		if (this.IsPartOfWidget)
		{
			this.m_UseEditorText = true;
			this.m_GameStringLookup = true;
			this.m_Cache = true;
		}
		if (!this.m_GameStringLookup && !this.m_TextSet && !this.m_UseEditorText && Application.IsPlaying(this))
		{
			this.m_Text = "";
		}
	}

	// Token: 0x0600881B RID: 34843 RVA: 0x002C928F File Offset: 0x002C748F
	private void Start()
	{
		this.m_updated = false;
	}

	// Token: 0x0600881C RID: 34844 RVA: 0x002C9298 File Offset: 0x002C7498
	private void Update()
	{
		this.CheckObjectLayer();
		this.CheckFontTextureSize();
		this.RenderText();
	}

	// Token: 0x0600881D RID: 34845 RVA: 0x002C92AC File Offset: 0x002C74AC
	private void CheckForWidgetTransform()
	{
		this.m_widgetTransform = base.GetComponent<WidgetTransform>();
		if (this.m_HadWidgetTransformLastCheck != this.IsPartOfWidget)
		{
			this.m_updated = false;
		}
		this.m_HadWidgetTransformLastCheck = this.IsPartOfWidget;
	}

	// Token: 0x0600881E RID: 34846 RVA: 0x002C92DC File Offset: 0x002C74DC
	private void CheckObjectLayer()
	{
		int layer = base.gameObject.layer;
		if (this.m_CurrentLayer != layer || (this.m_UberTextRendering != null && !this.m_UberTextRendering.HasLayer(layer)) || (this.m_UberTextRenderToTexture != null && !this.m_UberTextRenderToTexture.HasLayer(layer)))
		{
			this.UpdateLayers();
		}
	}

	// Token: 0x0600881F RID: 34847 RVA: 0x002C9330 File Offset: 0x002C7530
	private void CheckFontTextureSize()
	{
		if (this.m_UberTextRendering != null)
		{
			Texture fontTexture = this.m_UberTextRendering.GetFontTexture();
			if (fontTexture && (this.m_PreviousFontSize.x != fontTexture.width || this.m_PreviousFontSize.y != fontTexture.height))
			{
				this.m_updated = false;
			}
		}
	}

	// Token: 0x06008820 RID: 34848 RVA: 0x002C9386 File Offset: 0x002C7586
	private void OnDisable()
	{
		if (this.m_UberTextRendering == null || this.m_UberTextRenderToTexture == null)
		{
			return;
		}
		this.m_UberTextRenderToTexture.SetAllVisible(false);
	}

	// Token: 0x06008821 RID: 34849 RVA: 0x002C93A5 File Offset: 0x002C75A5
	private void OnDestroy()
	{
		this.CleanUp();
	}

	// Token: 0x06008822 RID: 34850 RVA: 0x002C93AD File Offset: 0x002C75AD
	private void OnEnable()
	{
		this.m_updated = false;
		if (this.m_UberTextRendering != null)
		{
			this.m_UberTextRendering.SetActive(true);
		}
		if (this.m_UberTextRenderToTexture != null)
		{
			this.m_UberTextRenderToTexture.SetActive(true);
		}
		this.SetFont();
		this.UpdateNow(false);
	}

	// Token: 0x06008823 RID: 34851 RVA: 0x002C93EC File Offset: 0x002C75EC
	private void OnDrawGizmos()
	{
		float width = this.GetWidth();
		float height = this.GetHeight();
		Gizmos.matrix = base.transform.localToWorldMatrix;
		if (this.IsPartOfWidget)
		{
			Gizmos.matrix *= Matrix4x4.TRS(this.GetTextCenter(), this.GetTextRotation(), Vector3.one);
		}
		Gizmos.color = new Color(0.3f, 0.3f, 0.35f, 0.2f);
		Gizmos.DrawCube(Vector3.zero, new Vector3(width, height, 0f));
		Gizmos.color = Color.black;
		Gizmos.DrawWireCube(Vector3.zero, new Vector3(width, height, 0f));
		if (this.m_Underwear)
		{
			float underwearWidth = this.m_UnderwearWidth;
			float underwearHeight = this.m_UnderwearHeight;
			if (this.m_LocalizedSettings != null)
			{
				UberText.LocalizationSettings.LocaleAdjustment locale = this.m_LocalizedSettings.GetLocale(Localization.GetLocale());
				if (locale != null)
				{
					if (locale.m_UnderwearWidth > 0f)
					{
						underwearWidth = locale.m_UnderwearWidth;
					}
					if (locale.m_UnderwearHeight > 0f)
					{
						underwearHeight = locale.m_UnderwearHeight;
					}
				}
			}
			float num = width * underwearWidth * 0.5f;
			float num2 = height * underwearHeight;
			if (this.m_UnderwearFlip)
			{
				Gizmos.DrawWireCube(new Vector3(-(width * 0.5f - num * 0.5f), height * 0.5f - num2 * 0.5f, 0f), new Vector3(num, num2, 0f));
				Gizmos.DrawWireCube(new Vector3(width * 0.5f - num * 0.5f, height * 0.5f - num2 * 0.5f, 0f), new Vector3(num, num2, 0f));
			}
			else
			{
				Gizmos.DrawWireCube(new Vector3(-(width * 0.5f - num * 0.5f), -(height * 0.5f - num2 * 0.5f), 0f), new Vector3(num, num2, 0f));
				Gizmos.DrawWireCube(new Vector3(width * 0.5f - num * 0.5f, -(height * 0.5f - num2 * 0.5f), 0f), new Vector3(num, num2, 0f));
			}
		}
		Gizmos.matrix = Matrix4x4.identity;
	}

	// Token: 0x06008824 RID: 34852 RVA: 0x002C9618 File Offset: 0x002C7818
	private void OnDrawGizmosSelected()
	{
		float width = this.GetWidth();
		float height = this.GetHeight();
		Gizmos.matrix = base.transform.localToWorldMatrix;
		if (this.IsPartOfWidget)
		{
			Gizmos.matrix *= Matrix4x4.TRS(this.GetTextCenter(), this.GetTextRotation(), Vector3.one);
		}
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube(Vector3.zero, new Vector3(width + this.GetGizmoBuffer(width), height + this.GetGizmoBuffer(height), 0f));
		Gizmos.matrix = Matrix4x4.identity;
	}

	// Token: 0x06008825 RID: 34853 RVA: 0x002C96AA File Offset: 0x002C78AA
	private float GetGizmoBuffer(float boundsValue)
	{
		return Mathf.Min(boundsValue * 0.04f, 0.1f);
	}

	// Token: 0x06008826 RID: 34854 RVA: 0x002C96BD File Offset: 0x002C78BD
	public void Show()
	{
		this.m_Hidden = false;
		this.UpdateNow(false);
	}

	// Token: 0x06008827 RID: 34855 RVA: 0x002C96CD File Offset: 0x002C78CD
	public void Hide()
	{
		this.m_Hidden = true;
		this.UpdateNow(false);
	}

	// Token: 0x06008828 RID: 34856 RVA: 0x002C96DD File Offset: 0x002C78DD
	public bool isHidden()
	{
		return this.m_Hidden;
	}

	// Token: 0x06008829 RID: 34857 RVA: 0x002C96E5 File Offset: 0x002C78E5
	public void EditorAwake()
	{
		this.UpdateText();
	}

	// Token: 0x0600882A RID: 34858 RVA: 0x002C96ED File Offset: 0x002C78ED
	public bool IsDone()
	{
		return this.m_updated;
	}

	// Token: 0x0600882B RID: 34859 RVA: 0x002C96F5 File Offset: 0x002C78F5
	public void UpdateText()
	{
		if (!base.gameObject.activeInHierarchy)
		{
			return;
		}
		this.m_updated = false;
	}

	// Token: 0x0600882C RID: 34860 RVA: 0x002C970C File Offset: 0x002C790C
	public void UpdateNow(bool updateIfInactive = false)
	{
		if (this == null || base.gameObject == null || (!base.gameObject.activeInHierarchy && !updateIfInactive))
		{
			return;
		}
		this.m_updated = false;
		this.RenderText();
	}

	// Token: 0x0600882D RID: 34861 RVA: 0x002C9744 File Offset: 0x002C7944
	public Bounds GetBounds()
	{
		Matrix4x4 matrix4x = base.transform.localToWorldMatrix * Matrix4x4.Rotate(this.GetTextRotation());
		Vector3 b = matrix4x.MultiplyVector(Vector3.up) * (this.GetHeight() * 0.5f);
		Vector3 b2 = matrix4x.MultiplyVector(Vector3.right) * (this.GetWidth() * 0.5f);
		return new Bounds
		{
			min = base.transform.position - b2 + b,
			max = base.transform.position + b2 - b
		};
	}

	// Token: 0x0600882E RID: 34862 RVA: 0x002C97F0 File Offset: 0x002C79F0
	public Bounds GetLocalBounds()
	{
		Matrix4x4 matrix4x = Matrix4x4.Rotate(this.GetTextRotation());
		Vector3 b = matrix4x.MultiplyVector(Vector3.up) * (this.GetHeight() * 0.5f);
		Vector3 b2 = matrix4x.MultiplyVector(Vector3.right) * (this.GetWidth() * 0.5f);
		return new Bounds
		{
			min = base.transform.position - b2 + b,
			max = base.transform.position + b2 - b
		};
	}

	// Token: 0x0600882F RID: 34863 RVA: 0x002C988C File Offset: 0x002C7A8C
	public Bounds GetTextBounds()
	{
		if (!this.m_updated)
		{
			this.UpdateNow(false);
		}
		if (this.m_UberTextRendering == null)
		{
			return new Bounds(Vector3.zero, Vector3.zero);
		}
		Quaternion rotation = base.transform.rotation;
		base.transform.rotation = Quaternion.identity;
		Bounds textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
		base.transform.rotation = rotation;
		return textMeshBounds;
	}

	// Token: 0x06008830 RID: 34864 RVA: 0x002C98F3 File Offset: 0x002C7AF3
	public Bounds GetTextWorldSpaceBounds()
	{
		if (!this.m_updated)
		{
			this.UpdateNow(false);
		}
		if (this.m_UberTextRendering == null)
		{
			return new Bounds(Vector3.zero, Vector3.zero);
		}
		return this.m_UberTextRendering.GetTextMeshBounds();
	}

	// Token: 0x06008831 RID: 34865 RVA: 0x002C9927 File Offset: 0x002C7B27
	public bool IsMultiLine()
	{
		return this.m_LineCount > 1;
	}

	// Token: 0x06008832 RID: 34866 RVA: 0x002C9932 File Offset: 0x002C7B32
	public bool IsEllipsized()
	{
		return this.m_Ellipsized;
	}

	// Token: 0x06008833 RID: 34867 RVA: 0x002C993A File Offset: 0x002C7B3A
	public void SetGameStringText(string gameStringTag)
	{
		this.Text = GameStrings.Get(gameStringTag);
	}

	// Token: 0x06008834 RID: 34868 RVA: 0x002C9948 File Offset: 0x002C7B48
	public Font GetLocalizedFont()
	{
		if (this.m_LocalizedFont)
		{
			return this.m_LocalizedFont;
		}
		return this.m_Font;
	}

	// Token: 0x06008835 RID: 34869 RVA: 0x002C9964 File Offset: 0x002C7B64
	public UberText.LocalizationSettings.LocaleAdjustment AddLocaleAdjustment(Locale locale)
	{
		return this.m_LocalizedSettings.AddLocale(locale);
	}

	// Token: 0x06008836 RID: 34870 RVA: 0x002C9972 File Offset: 0x002C7B72
	public UberText.LocalizationSettings.LocaleAdjustment GetLocaleAdjustment(Locale locale)
	{
		return this.m_LocalizedSettings.GetLocale(locale);
	}

	// Token: 0x06008837 RID: 34871 RVA: 0x002C9980 File Offset: 0x002C7B80
	public void RemoveLocaleAdjustment(Locale locale)
	{
		this.m_LocalizedSettings.RemoveLocale(locale);
	}

	// Token: 0x06008838 RID: 34872 RVA: 0x002C8FD7 File Offset: 0x002C71D7
	public UberText.LocalizationSettings GetAllLocalizationSettings()
	{
		return this.m_LocalizedSettings;
	}

	// Token: 0x06008839 RID: 34873 RVA: 0x002C9990 File Offset: 0x002C7B90
	public void SetFontWithoutLocalization(FontDefinition fontDef)
	{
		Font font = fontDef.m_Font;
		if (font == null)
		{
			return;
		}
		if (this.m_UberTextRendering != null && !this.m_UberTextRendering.CanSetFont(font))
		{
			return;
		}
		this.m_Font = font;
		this.m_LocalizedFont = this.m_Font;
		this.m_LineSpaceModifier = fontDef.m_LineSpaceModifier;
		this.m_FontSizeModifier = fontDef.m_FontSizeModifier;
		this.m_SingleLineAdjustment = fontDef.m_SingleLineAdjustment;
		this.m_CharacterSizeModifier = fontDef.m_CharacterSizeModifier;
		this.m_UnboundCharacterSizeModifier = fontDef.m_UnboundCharacterSizeModifier;
		this.m_OutlineModifier = fontDef.m_OutlineModifier;
		this.m_isFontDefLoaded = true;
		if (this.m_UberTextRendering != null)
		{
			this.m_UberTextRendering.SetFont(this.m_Font);
		}
		this.UpdateNow(false);
	}

	// Token: 0x0600883A RID: 34874 RVA: 0x002C9A48 File Offset: 0x002C7C48
	public string GetProcessedText()
	{
		if (this.m_UberTextRendering == null)
		{
			return string.Empty;
		}
		return this.m_UberTextRendering.GetText().Replace("<material=1></material>", string.Empty).Replace("<material=1>", "<b>").Replace("</material>", "</b>");
	}

	// Token: 0x0600883B RID: 34875 RVA: 0x002C9A9C File Offset: 0x002C7C9C
	public static void RebuildAllUberText()
	{
		UberText[] array = UnityEngine.Object.FindObjectsOfType<UberText>();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].UpdateNow(false);
		}
	}

	// Token: 0x0600883C RID: 34876 RVA: 0x002C9AC8 File Offset: 0x002C7CC8
	private void RenderText()
	{
		if (!this.CanRenderText())
		{
			return;
		}
		if (string.IsNullOrEmpty(this.m_Text) || this.m_Hidden)
		{
			this.SetRenderedObjectsVisible(false);
			return;
		}
		this.SetWorldWidthAndHeight();
		this.CreateTextMesh();
		this.UpdateTextPosition();
		this.SetFont();
		this.SetFontSize(this.m_FontSize);
		this.SetLineSpacing(this.m_LineSpacing);
		this.SetupTextMeshAlignment();
		this.m_UberTextRendering.SetLocale(Localization.GetLocale());
		this.SetupTextAndCharacterSize();
		this.SetupTextMeshAlignment();
		this.UpdateOutlineProperties();
		this.UpdateTexelSize();
		this.UpdateLayers();
		this.UpdateRenderQueue();
		this.UpdateColor();
		this.m_UberTextRendering.SetBoldEnabled(this.m_HasBoldText);
		this.m_UberTextRendering.SetOutlineEnabled(this.m_Outline);
		this.m_UberTextRendering.ApplyMaterials();
		if (this.m_RenderToTexture)
		{
			this.SetupRenderToTexture();
		}
		this.SetRenderedObjectsVisible(true);
		if (this.m_RenderToTexture)
		{
			this.m_UberTextRenderToTexture.DoRenderToTexture();
			if (this.m_AntiAlias)
			{
				this.m_UberTextRenderToTexture.ApplyAntialiasing();
			}
		}
		this.m_PreviousText = this.m_Text;
		this.m_updated = true;
	}

	// Token: 0x0600883D RID: 34877 RVA: 0x002C9BE8 File Offset: 0x002C7DE8
	private bool CanRenderText()
	{
		if (this.m_RenderToTexture && this.m_UberTextRenderToTexture != null)
		{
			this.m_updated = (this.m_updated && this.m_UberTextRenderToTexture.IsRenderTextureCreated());
		}
		if (this.m_updated || this.m_UberTextRendering == null || this.m_UberTextRenderToTexture == null)
		{
			return false;
		}
		if (!this.m_Font)
		{
			Debug.LogWarning(string.Format("UberText error: Font is null for {0}", base.gameObject.name));
			return false;
		}
		return true;
	}

	// Token: 0x0600883E RID: 34878 RVA: 0x002C9C65 File Offset: 0x002C7E65
	private void SetRenderedObjectsVisible(bool visible)
	{
		this.m_UberTextRendering.SetVisible(visible);
		this.m_UberTextRenderToTexture.SetAllVisible(visible);
	}

	// Token: 0x0600883F RID: 34879 RVA: 0x002C9C7F File Offset: 0x002C7E7F
	private bool CanUseCachedText()
	{
		return 0 == 0;
	}

	// Token: 0x06008840 RID: 34880 RVA: 0x002C9C88 File Offset: 0x002C7E88
	private void SetupTextAndCharacterSize()
	{
		this.m_UberTextRendering.SetCharacterSize(this.m_CharacterSize * this.m_CharacterSizeModifier * 0.01f);
		string text = string.Empty;
		bool flag = false;
		bool flag2 = this.CanUseCachedText();
		if (flag2)
		{
			this.m_CacheHash = new UberText.CachedTextKeyData
			{
				m_Text = this.m_Text,
				m_CharSize = this.m_CharacterSize,
				m_Font = this.m_Font,
				m_FontSize = this.m_FontSize,
				m_Height = this.GetHeight(),
				m_Width = this.GetWidth(),
				m_LineSpacing = this.m_LineSpacing
			}.GetHashCode();
			if (this.m_Cache && (this.m_WordWrap || this.m_ResizeToFit) && UberText.s_CachedText.ContainsKey(this.m_CacheHash))
			{
				UberText.CachedTextValues cachedTextValues = UberText.s_CachedText[this.m_CacheHash];
				if (cachedTextValues.m_OriginalTextHash == this.m_Text.GetHashCode())
				{
					text = cachedTextValues.m_Text;
					this.m_UberTextRendering.SetText(text);
					this.m_UberTextRendering.SetCharacterSize(cachedTextValues.m_CharSize);
					this.SetLineSpacing(this.m_LineSpacing);
					flag = true;
				}
			}
		}
		Quaternion rotation = base.transform.rotation;
		base.transform.rotation = Quaternion.identity;
		if (!flag)
		{
			string text2 = this.m_Text;
			text = string.Empty;
			if (this.m_GameStringLookup)
			{
				text2 = GameStrings.Get(text2.Trim());
			}
			if (Localization.GetLocale() != Locale.enUS)
			{
				text2 = this.LocalizationFixes(text2);
			}
			text = this.ProcessText(text2);
			this.m_Words = this.BreakStringIntoWords(text);
			this.m_LineCount = UberText.LineCount(text);
			this.m_Ellipsized = false;
			if (this.m_WordWrap && !this.m_ResizeToFit)
			{
				this.m_UberTextRendering.SetText(this.WordWrapString(text, this.GetWidth()));
			}
			else
			{
				this.m_UberTextRendering.SetText(text);
			}
			this.m_UberTextRendering.SetCharacterSize(this.m_CharacterSize * this.m_CharacterSizeModifier * 0.01f);
		}
		if (this.m_ResizeToFit && !flag)
		{
			this.ResizeTextToFit(text);
		}
		base.transform.rotation = rotation;
		if (flag2 && this.m_Cache && !flag && (this.m_WordWrap || this.m_ResizeToFit))
		{
			double num = 0.0;
			if (!double.TryParse(this.m_Text, out num) && this.m_Text.Length > 3)
			{
				UberText.s_CachedText[this.m_CacheHash] = new UberText.CachedTextValues();
				UberText.s_CachedText[this.m_CacheHash].m_Text = this.m_UberTextRendering.GetText();
				UberText.s_CachedText[this.m_CacheHash].m_CharSize = this.m_UberTextRendering.GetCharacterSize();
				UberText.s_CachedText[this.m_CacheHash].m_OriginalTextHash = this.m_Text.GetHashCode();
			}
		}
		float num2 = 1f;
		float unboundedCharSize = UberTextLocalization.GetUnboundedCharSize(this.m_LocalizedSettings);
		if (unboundedCharSize > 0f)
		{
			num2 = unboundedCharSize;
		}
		float num3 = this.m_UberTextRendering.GetCharacterSize();
		num3 *= this.m_UnboundCharacterSizeModifier * num2;
		this.m_UberTextRendering.SetCharacterSize(num3);
	}

	// Token: 0x06008841 RID: 34881 RVA: 0x002C9FBC File Offset: 0x002C81BC
	private void SetupTextMeshAlignment()
	{
		float width = this.GetWidth();
		float height = this.GetHeight();
		this.m_UberTextRendering.SetTextAlignment(this.m_Alignment);
		this.m_UberTextRendering.SetTextMeshGameObjectLocalPosition(this.GetTextCenter());
		this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(UberTextLocalization.GetPositionOffset(this.m_LocalizedSettings));
		switch (this.m_Alignment)
		{
		case UberText.AlignmentOptions.Left:
			switch (this.m_Anchor)
			{
			case UberText.AnchorOptions.Upper:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(-width * 0.5f, height * 0.5f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.UpperLeft);
				return;
			case UberText.AnchorOptions.Middle:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(-width * 0.5f, 0f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.MiddleLeft);
				return;
			case UberText.AnchorOptions.Lower:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(-width * 0.5f, -height * 0.5f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.LowerLeft);
				return;
			default:
				return;
			}
			break;
		case UberText.AlignmentOptions.Center:
			switch (this.m_Anchor)
			{
			case UberText.AnchorOptions.Upper:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(0f, height * 0.5f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.UpperCenter);
				return;
			case UberText.AnchorOptions.Middle:
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.MiddleCenter);
				return;
			case UberText.AnchorOptions.Lower:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(0f, -height * 0.5f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.LowerCenter);
				return;
			default:
				return;
			}
			break;
		case UberText.AlignmentOptions.Right:
			switch (this.m_Anchor)
			{
			case UberText.AnchorOptions.Upper:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(width * 0.5f, height * 0.5f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.UpperRight);
				return;
			case UberText.AnchorOptions.Middle:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(width * 0.5f, 0f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.MiddleRight);
				return;
			case UberText.AnchorOptions.Lower:
				this.m_UberTextRendering.SetTextMeshGameObjectLocalPositionOffset(this.GetAlignmentOffset(width * 0.5f, -height * 0.5f));
				this.m_UberTextRendering.SetTextAnchor(TextAnchor.LowerRight);
				return;
			default:
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06008842 RID: 34882 RVA: 0x002CA1E1 File Offset: 0x002C83E1
	private Vector3 GetAlignmentOffset(float width, float height)
	{
		if (!this.IsPartOfWidget)
		{
			return new Vector3(width, height, 0f);
		}
		return new Vector3(width, 0f, height);
	}

	// Token: 0x06008843 RID: 34883 RVA: 0x002CA204 File Offset: 0x002C8404
	private void UpdateTextPosition()
	{
		if (this.m_RenderToTexture)
		{
			this.m_UberTextRendering.SetTextMeshRenderToTextureTransform(this.Offset);
			return;
		}
		this.m_UberTextRendering.SetTextMeshTransform(base.gameObject, this.GetTextCenter(), this.GetTextRotation());
	}

	// Token: 0x06008844 RID: 34884 RVA: 0x002CA240 File Offset: 0x002C8440
	private void UpdateColor()
	{
		this.m_updated = false;
		if (this.m_UberTextRendering == null || this.m_UberTextRenderToTexture == null)
		{
			return;
		}
		this.m_UberTextRendering.SetTextColor(this.m_TextColor);
		this.m_UberTextRendering.SetOutlineColor(this.m_OutlineColor);
		this.m_UberTextRendering.SetAmbientLightBlend(this.m_AmbientLightBlend);
		this.m_UberTextRenderToTexture.SetShadowColor(this.m_ShadowColor);
		this.m_UberTextRenderToTexture.SetGradientColors(this.m_GradientUpperColor, this.m_GradientLowerColor);
	}

	// Token: 0x06008845 RID: 34885 RVA: 0x002CA2C0 File Offset: 0x002C84C0
	private void UpdateLayers()
	{
		this.m_CurrentLayer = base.gameObject.layer;
		if (this.m_UberTextRendering != null)
		{
			this.m_UberTextRendering.SetLayer(this.m_CurrentLayer);
		}
		if (this.m_UberTextRenderToTexture != null)
		{
			this.m_UberTextRenderToTexture.SetLayer(this.m_CurrentLayer);
		}
	}

	// Token: 0x06008846 RID: 34886 RVA: 0x002CA310 File Offset: 0x002C8510
	private void UpdateRenderQueue()
	{
		if (this.m_UberTextRendering == null || this.m_UberTextRenderToTexture == null)
		{
			return;
		}
		this.m_UberTextRendering.SetRenderQueueIncrement(this.m_RenderQueue);
		this.m_UberTextRenderToTexture.SetRenderQueueIncrement(this.m_RenderQueue);
		this.m_UberTextRenderToTexture.SetShadowRenderQueueIncrement(this.m_RenderQueue + this.m_ShadowRenderQueueOffset);
	}

	// Token: 0x06008847 RID: 34887 RVA: 0x002CA368 File Offset: 0x002C8568
	private void UpdateTexelSize()
	{
		float num = this.m_OutlineSize * this.m_OutlineModifier * UberTextLocalization.GetOutlineModifier(this.m_LocalizedSettings);
		Texture fontTexture = this.m_UberTextRendering.GetFontTexture();
		if (fontTexture == null)
		{
			if (!Application.IsPlaying(this))
			{
				return;
			}
			Debug.LogError(string.Format("UberText.UpdateTexelSize() - m_FontTexture == null!  text={0}", this.m_Text));
			return;
		}
		else
		{
			Vector2 vector = this.TexelSize(fontTexture);
			if (vector == this.m_PreviousTexelSize)
			{
				return;
			}
			this.m_UberTextRendering.SetBoldOffset(vector * this.m_BoldSize);
			this.m_UberTextRendering.SetOutlineOffset(vector * num);
			this.m_UberTextRendering.SetOutlineBoldOffset(vector * (num + this.m_BoldSize * 0.75f));
			this.m_UberTextRendering.SetTexelSize(vector);
			this.m_PreviousTexelSize = vector;
			this.m_PreviousFontSize = new Vector2Int(fontTexture.width, fontTexture.height);
			return;
		}
	}

	// Token: 0x06008848 RID: 34888 RVA: 0x002CA44C File Offset: 0x002C864C
	private void CreateTextMesh()
	{
		this.m_UberTextRendering.Init(base.gameObject);
		this.m_meshReadyTracker.SetAndDispatch();
		this.m_UberTextRendering.SetRichText(this.m_RichText);
		this.m_UberTextRendering.SetInlineImageEnabled(false);
		this.m_HasBoldText = false;
		if (this.m_Text.Contains("<b>"))
		{
			this.Bold();
		}
	}

	// Token: 0x06008849 RID: 34889 RVA: 0x002CA4B4 File Offset: 0x002C86B4
	private void SetFont()
	{
		if (this.m_Font == null)
		{
			return;
		}
		FontTable fontTable;
		if (!this.m_isFontDefLoaded && HearthstoneServices.TryGet<FontTable>(out fontTable))
		{
			FontDefinition fontDef = fontTable.GetFontDef(this.m_Font);
			if (fontDef != null)
			{
				this.m_LocalizedFont = fontDef.m_Font;
				this.m_LineSpaceModifier = fontDef.m_LineSpaceModifier;
				this.m_FontSizeModifier = fontDef.m_FontSizeModifier;
				this.m_SingleLineAdjustment = fontDef.m_SingleLineAdjustment;
				this.m_CharacterSizeModifier = fontDef.m_CharacterSizeModifier;
				this.m_UnboundCharacterSizeModifier = fontDef.m_UnboundCharacterSizeModifier;
				this.m_OutlineModifier = fontDef.m_OutlineModifier;
				this.m_isFontDefLoaded = true;
			}
			else
			{
				Debug.LogErrorFormat("Error loading fontDef for UberText component={0} font={1}", new object[]
				{
					base.name,
					this.m_Font
				});
			}
		}
		if (this.m_UberTextRendering != null)
		{
			if (this.m_LocalizedFont == null)
			{
				this.m_UberTextRendering.SetFont(this.m_Font);
				return;
			}
			this.m_UberTextRendering.SetFont(this.m_LocalizedFont);
		}
	}

	// Token: 0x0600884A RID: 34890 RVA: 0x002CA5B5 File Offset: 0x002C87B5
	private void SetFontSize(int fontSize)
	{
		fontSize = (int)(this.m_FontSizeModifier * UberTextLocalization.GetFontSizeModifier(this.m_LocalizedSettings) * (float)fontSize);
		this.m_UberTextRendering.SetFontSize(fontSize);
	}

	// Token: 0x0600884B RID: 34891 RVA: 0x002CA5DC File Offset: 0x002C87DC
	private float GetWidth()
	{
		float width = this.m_Width;
		if (this.IsPartOfWidget)
		{
			width = this.m_widgetTransform.Rect.width;
		}
		if (this.m_LocalizedSettings != null)
		{
			UberText.LocalizationSettings.LocaleAdjustment locale = this.m_LocalizedSettings.GetLocale(Localization.GetLocale());
			if (locale != null && locale.m_Width > 0f)
			{
				width = locale.m_Width;
			}
		}
		return width;
	}

	// Token: 0x0600884C RID: 34892 RVA: 0x002CA640 File Offset: 0x002C8840
	private float GetHeight()
	{
		float height = this.m_Height;
		if (this.IsPartOfWidget)
		{
			height = this.m_widgetTransform.Rect.height;
		}
		if (this.m_LocalizedSettings != null)
		{
			UberText.LocalizationSettings.LocaleAdjustment locale = this.m_LocalizedSettings.GetLocale(Localization.GetLocale());
			if (locale != null && locale.m_Height > 0f)
			{
				height = locale.m_Height;
			}
		}
		return height;
	}

	// Token: 0x0600884D RID: 34893 RVA: 0x002CA6A4 File Offset: 0x002C88A4
	private void SetLineSpacing(float lineSpacing)
	{
		if (UberText.LineCount(this.m_UberTextRendering.GetText()) == 1)
		{
			lineSpacing += this.m_SingleLineAdjustment + UberTextLocalization.GetSingleLineAdjustment(this.m_LocalizedSettings);
		}
		else
		{
			lineSpacing *= this.m_LineSpaceModifier * UberTextLocalization.GetLineSpaceModifier(this.m_LocalizedSettings);
		}
		this.m_UberTextRendering.SetLineSpacing(lineSpacing);
	}

	// Token: 0x0600884E RID: 34894 RVA: 0x002CA700 File Offset: 0x002C8900
	private void SetupRenderToTexture()
	{
		this.m_UberTextRendering.SetTextMeshRenderToTextureTransform(this.Offset);
		Vector2Int renderTextureSize = this.CalcTextureSize();
		if (this.m_RenderOnObject)
		{
			this.m_UberTextRenderToTexture.InitOnRenderObject(this.m_RenderOnObject, renderTextureSize);
		}
		else
		{
			this.SetupRenderOnPlane(renderTextureSize);
			this.SetupShadow();
		}
		this.SetupCamera();
		this.SetupAntialias();
	}

	// Token: 0x0600884F RID: 34895 RVA: 0x002CA760 File Offset: 0x002C8960
	private void SetupRenderOnPlane(Vector2Int renderTextureSize)
	{
		Vector2 planeSize = new Vector2(this.GetWidth(), this.GetHeight());
		this.m_UberTextRenderToTexture.InitOnPlane(base.gameObject, planeSize, this.m_GradientUpperColor, this.m_GradientLowerColor, renderTextureSize);
		Vector3 zero = Vector3.zero;
		if (this.m_widgetTransform == null)
		{
			zero.x = -90f;
		}
		this.m_UberTextRenderToTexture.SetPlaneLocalPosition(this.GetTextCenter() + UberTextLocalization.GetPositionOffset(this.m_LocalizedSettings));
		this.m_UberTextRenderToTexture.SetPlaneRotation(base.transform.rotation);
		this.m_UberTextRenderToTexture.DoPlaneRotate(zero);
	}

	// Token: 0x06008850 RID: 34896 RVA: 0x002CA802 File Offset: 0x002C8A02
	private void SetupAntialias()
	{
		if (this.m_AntiAlias)
		{
			this.m_UberTextRenderToTexture.SetAntialiasEdge(this.m_AntiAliasEdge);
			this.m_UberTextRenderToTexture.SetAntialiasOffset(this.m_AntiAliasAmount);
		}
	}

	// Token: 0x06008851 RID: 34897 RVA: 0x002CA830 File Offset: 0x002C8A30
	private void SetupCamera()
	{
		Color cameraBackgroundColor = this.m_TextColor;
		if (this.m_Outline)
		{
			cameraBackgroundColor = this.m_OutlineColor;
		}
		this.m_UberTextRenderToTexture.SetCameraBackgroundColor(cameraBackgroundColor);
		this.m_UberTextRenderToTexture.SetCameraPosition(this.Alignment, this.m_Anchor, new Vector2(this.GetWidth(), this.GetHeight()), this.Offset);
	}

	// Token: 0x06008852 RID: 34898 RVA: 0x002CA890 File Offset: 0x002C8A90
	private void ResizeTextToFit(string text)
	{
		if (text == null || text == string.Empty)
		{
			return;
		}
		UberTextRendering.TransformBackup transformBackup = this.m_UberTextRendering.BackupTextMeshTransform();
		this.m_UberTextRendering.SetTextMeshGameObjectParent(null);
		this.m_UberTextRendering.SetTextMeshGameObjectLocalScale(Vector3.one);
		this.m_UberTextRendering.SetTextMeshGameObjectRotation(Quaternion.identity);
		float width = this.GetWidth();
		string text3;
		string text2 = this.RemoveTagsFromWord(text, out text3);
		if (text2 == null)
		{
			text2 = string.Empty;
		}
		this.m_UberTextRendering.SetText(text2);
		if (this.m_WordWrap)
		{
			this.m_UberTextRendering.SetText(this.WordWrapString(text, width));
		}
		if (this.m_ResizeToFitAndGrow)
		{
			this.ResizeToFitBounds_CharSize(text);
		}
		else
		{
			this.ReduceText_CharSize(text);
		}
		this.m_UberTextRendering.SetTextMeshGameObjectParent(transformBackup.Parent);
		this.m_UberTextRendering.SetTextMeshGameObjectLocalPosition(transformBackup.LocalPosition);
		this.m_UberTextRendering.SetTextMeshGameObjectLocalScale(transformBackup.LocalScale);
		this.m_UberTextRendering.SetTextMeshGameObjectRotation(transformBackup.Rotation);
		if (!this.m_WordWrap)
		{
			this.m_UberTextRendering.SetText(text);
		}
	}

	// Token: 0x06008853 RID: 34899 RVA: 0x002CA998 File Offset: 0x002C8B98
	private void ReduceText(string text, int step, int newSize)
	{
		if (this.m_FontSize == 1)
		{
			return;
		}
		this.SetFontSize(newSize);
		float num = this.GetHeight();
		float num2 = this.GetWidth();
		if (!this.m_RenderToTexture)
		{
			num = this.m_WorldHeight;
			num2 = this.m_WorldWidth;
		}
		if (!this.IsMultiLine())
		{
			this.SetLineSpacing(0f);
		}
		Bounds textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
		float y = textMeshBounds.size.y;
		float x = textMeshBounds.size.x;
		int num3 = 0;
		while (y > num || x > num2)
		{
			num3++;
			if (num3 > 40)
			{
				break;
			}
			newSize -= step;
			if (newSize < this.m_MinFontSize)
			{
				newSize = this.m_MinFontSize;
				break;
			}
			this.SetFontSize(newSize);
			if (this.m_WordWrap)
			{
				this.m_UberTextRendering.SetText(this.WordWrapString(text, num2));
			}
			textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
			y = textMeshBounds.size.y;
			x = textMeshBounds.size.x;
		}
		if (!this.IsMultiLine())
		{
			this.SetLineSpacing(this.m_LineSpacing);
		}
		this.m_FontSize = newSize;
	}

	// Token: 0x06008854 RID: 34900 RVA: 0x002CAAAC File Offset: 0x002C8CAC
	private float Measure_IntraLine_Height()
	{
		string text = this.m_UberTextRendering.GetText();
		this.m_UberTextRendering.SetText("|");
		float y = this.m_UberTextRendering.GetTextMeshBounds().size.y;
		this.m_UberTextRendering.SetText("|\n|");
		float result = this.m_UberTextRendering.GetTextMeshBounds().size.y - y * 2f;
		this.m_UberTextRendering.SetText(text);
		return result;
	}

	// Token: 0x06008855 RID: 34901 RVA: 0x002CAB2C File Offset: 0x002C8D2C
	private void ReduceText_CharSize(string text)
	{
		float height = this.GetHeight();
		float width = this.GetWidth();
		float num = this.m_UberTextRendering.GetCharacterSize();
		if (!this.IsMultiLine())
		{
			this.SetLineSpacing(0f);
		}
		else
		{
			this.SetLineSpacing(this.m_LineSpacing);
		}
		Bounds textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
		float x = textMeshBounds.size.x;
		float num2 = textMeshBounds.size.y;
		int num3 = 0;
		num2 -= this.Measure_IntraLine_Height();
		float num4 = 1f;
		if (this.m_LocalizedSettings != null)
		{
			UberText.LocalizationSettings.LocaleAdjustment locale = this.m_LocalizedSettings.GetLocale(Localization.GetLocale());
			if (locale != null && locale.m_ResizeToFitWidthModifier > 0f)
			{
				num4 = locale.m_ResizeToFitWidthModifier;
			}
		}
		while (num2 > height || x > width * num4)
		{
			num3++;
			if (num3 > 40)
			{
				break;
			}
			num *= 0.95f;
			if (num <= this.m_MinCharacterSize * 0.01f)
			{
				num = this.m_MinCharacterSize * 0.01f;
				this.m_UberTextRendering.SetCharacterSize(num);
				if (this.m_WordWrap)
				{
					this.m_UberTextRendering.SetText(this.WordWrapString(text, width, true));
					break;
				}
				break;
			}
			else
			{
				this.m_UberTextRendering.SetCharacterSize(num);
				if (this.m_WordWrap)
				{
					this.m_UberTextRendering.SetText(this.WordWrapString(text, width, false));
				}
				if (UberText.LineCount(this.m_UberTextRendering.GetText()) > 1)
				{
					this.SetLineSpacing(this.m_LineSpacing);
				}
				else
				{
					this.SetLineSpacing(0f);
				}
				textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
				x = textMeshBounds.size.x;
				num2 = textMeshBounds.size.y;
			}
		}
		this.SetLineSpacing(this.m_LineSpacing);
	}

	// Token: 0x06008856 RID: 34902 RVA: 0x002CACF4 File Offset: 0x002C8EF4
	private void ResizeToFitBounds_CharSize(string text)
	{
		float height = this.GetHeight();
		float width = this.GetWidth();
		float num = this.m_UberTextRendering.GetCharacterSize();
		this.SetLineSpacing(this.IsMultiLine() ? this.m_LineSpacing : 0f);
		Bounds textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
		float x = textMeshBounds.size.x;
		float y = textMeshBounds.size.y;
		float num2 = y * 0.01f;
		float num3 = x * 0.01f;
		int num4 = 0;
		bool flag = x - num3 < width;
		bool flag2 = x + num3 > width;
		bool flag3 = y - num2 < height;
		bool flag4 = y + num2 > height;
		if (!this.m_WordWrap && (flag || flag2))
		{
			float val = height / y;
			float val2 = width / x;
			float num5 = Math.Min(val, val2);
			num *= num5;
			if (num <= this.m_MinCharacterSize * 0.01f)
			{
				num = this.m_MinCharacterSize * 0.01f;
			}
			this.m_UberTextRendering.SetCharacterSize(num);
		}
		while (this.m_WordWrap && (flag3 || flag4))
		{
			num4++;
			if (num4 > 40)
			{
				break;
			}
			float num6 = flag3 ? (1f + this.m_ResizeToGrowStep) : (1f - this.m_ResizeToGrowStep);
			bool flag5 = false;
			string text2 = this.m_UberTextRendering.GetText();
			int num7 = UberText.LineCount(text2);
			num *= num6;
			if (num <= this.m_MinCharacterSize * 0.01f)
			{
				num = this.m_MinCharacterSize * 0.01f;
				flag5 = true;
			}
			this.m_UberTextRendering.SetCharacterSize(num);
			this.m_UberTextRendering.SetText(this.WordWrapString(text, width, false));
			this.SetLineSpacing(this.IsMultiLine() ? this.m_LineSpacing : 0f);
			textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
			x = textMeshBounds.size.x;
			y = textMeshBounds.size.y;
			num2 = y * 0.01f;
			bool flag6 = num7 < UberText.LineCount(this.m_UberTextRendering.GetText());
			bool flag7 = !flag3 && y - num2 < height;
			bool flag8 = flag3 && y + num2 > height;
			if (flag6 && flag8)
			{
				this.m_UberTextRendering.SetText(text2);
			}
			if (flag5 || flag7 || flag8)
			{
				break;
			}
		}
		this.SetLineSpacing(this.m_LineSpacing);
	}

	// Token: 0x06008857 RID: 34903 RVA: 0x002CAF3C File Offset: 0x002C913C
	private Vector3 GetTextCenter()
	{
		if (this.IsPartOfWidget)
		{
			Vector3 v = this.m_widgetTransform.Rect.center;
			return WidgetTransform.GetRotationMatrixFromZNegativeToDesiredFacing(this.m_widgetTransform.Facing) * v;
		}
		return Vector3.zero;
	}

	// Token: 0x06008858 RID: 34904 RVA: 0x002CAF90 File Offset: 0x002C9190
	private Quaternion GetTextRotation()
	{
		if (this.IsPartOfWidget)
		{
			return WidgetTransform.GetRotationFromZNegativeToDesiredFacing(this.m_widgetTransform.Facing);
		}
		return Quaternion.identity;
	}

	// Token: 0x06008859 RID: 34905 RVA: 0x002CAFB0 File Offset: 0x002C91B0
	private string WordWrapString(string text, float width)
	{
		return this.WordWrapString(text, width, false);
	}

	// Token: 0x0600885A RID: 34906 RVA: 0x002CAFBC File Offset: 0x002C91BC
	private string WordWrapString(string text, float width, bool ellipsis)
	{
		if (text == null || text == string.Empty)
		{
			return string.Empty;
		}
		if (this.m_Words == null)
		{
			return text;
		}
		float width2 = this.GetWidth();
		float height = this.GetHeight();
		float num = width;
		float num2 = 0f;
		float num3 = 0f;
		Bounds bounds = default(Bounds);
		Bounds bounds2 = default(Bounds);
		UberTextRendering.TransformBackup transformBackup = this.m_UberTextRendering.BackupTextMeshTransform();
		this.m_UberTextRendering.SetTextMeshGameObjectParent(null);
		this.m_UberTextRendering.SetTextMeshGameObjectRotation(Quaternion.identity);
		this.m_UberTextRendering.SetTextMeshGameObjectPosition(new Vector3(0f, height * 0.25f, 0f));
		this.m_UberTextRendering.SetTextMeshGameObjectLocalScale(Vector3.one);
		if (this.m_Underwear)
		{
			num2 = this.m_UnderwearHeight;
			num3 = this.m_UnderwearWidth;
			if (this.m_LocalizedSettings != null)
			{
				UberText.LocalizationSettings.LocaleAdjustment locale = this.m_LocalizedSettings.GetLocale(Localization.GetLocale());
				if (locale != null)
				{
					if (locale.m_UnderwearWidth > 0f)
					{
						num3 = locale.m_UnderwearWidth;
					}
					if (locale.m_UnderwearHeight > 0f)
					{
						num2 = locale.m_UnderwearHeight;
					}
				}
			}
			if (this.m_UnderwearFlip)
			{
				num2 = height * num2;
			}
			else
			{
				num2 = height * (1f - num2);
			}
			num3 = width * (1f - num3);
			Vector3 size = new Vector3(width2 * this.m_UnderwearWidth * 0.5f, height * this.m_UnderwearHeight * 0.5f, 1f);
			float num4 = 0f;
			if (this.m_UnderwearFlip)
			{
				num4 = num4 + height * 0.5f - height * this.m_UnderwearHeight * 0.5f;
			}
			else
			{
				num4 = num4 - height * 0.5f + height * this.m_UnderwearHeight * 0.5f;
			}
			Vector3 zero = Vector3.zero;
			zero.x = zero.x + width2 * 0.5f - width2 * 0.5f * this.m_UnderwearWidth * 0.5f;
			zero.y = num4;
			bounds.center = zero;
			bounds.size = size;
			Vector3 zero2 = Vector3.zero;
			zero2.x = zero2.x - width2 * 0.5f + width2 * 0.5f * this.m_UnderwearWidth * 0.5f;
			zero2.y = num4;
			bounds2.center = zero2;
			bounds2.size = size;
		}
		TextAnchor textAnchor = this.m_UberTextRendering.GetTextAnchor();
		if (this.m_Underwear)
		{
			this.m_UberTextRendering.SetTextAnchor(TextAnchor.UpperCenter);
		}
		string[] array = this.ForceSplitLargeWords(this.m_Words, width, ellipsis);
		int num5 = 0;
		if (text.Contains("\n"))
		{
			string text2 = text;
			for (int i = 0; i < text2.Length; i++)
			{
				if ((byte)text2[i] == 10)
				{
					num5++;
				}
			}
		}
		bool flag = false;
		if (this.m_Underwear && !this.m_UnderwearFlip)
		{
			flag = true;
		}
		int length = text.Length;
		if (this.m_Underwear && this.m_UnderwearFlip)
		{
			StringBuilder stringBuilder = new StringBuilder(length, length);
			StringBuilder stringBuilder2 = new StringBuilder(length, length);
			foreach (string text3 in array)
			{
				string text2;
				string value = this.RemoveTagsFromWord(text3, out text2);
				stringBuilder2.Append(value);
				string text4 = stringBuilder2.ToString();
				if (text4 == null)
				{
					Debug.LogWarning("UberText: actualLine is null in WordWrapString!");
					text4 = string.Empty;
				}
				this.m_UberTextRendering.SetText(text4);
				if (this.m_UberTextRendering.GetTextMeshBounds().size.x >= width)
				{
					flag = true;
					break;
				}
				stringBuilder.Append(text3);
			}
			if (stringBuilder.ToString().Contains("\n"))
			{
				flag = true;
			}
		}
		int num6 = array.Length * 3 + length;
		StringBuilder stringBuilder3 = new StringBuilder(num6, num6);
		StringBuilder stringBuilder4 = new StringBuilder(length + 3, length + 3);
		string empty = string.Empty;
		foreach (string text5 in array)
		{
			string text6;
			string value2 = this.RemoveTagsFromWord(text5, out text6);
			stringBuilder4.Append(value2);
			string text7 = stringBuilder4.ToString();
			if (text7 == null)
			{
				Debug.LogWarning("UberText: actualLine is null in WordWrapString!");
				text7 = string.Empty;
			}
			this.m_UberTextRendering.SetText(text7);
			float x = this.m_UberTextRendering.GetTextMeshBounds().size.x;
			if (this.m_Underwear && flag)
			{
				this.m_UberTextRendering.SetText(stringBuilder3.ToString());
				Bounds textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
				float y = textMeshBounds.size.y;
				if (this.m_UnderwearFlip)
				{
					if (y - (height - y) * 0.2f < num2)
					{
						width = num3;
					}
					else
					{
						width = num;
					}
				}
				else if (textMeshBounds.Intersects(bounds) || textMeshBounds.Intersects(bounds2))
				{
					width = num3;
				}
			}
			if (x < width)
			{
				stringBuilder3.Append(text5);
			}
			else
			{
				if (ellipsis)
				{
					this.m_UberTextRendering.SetText(stringBuilder3.ToString() + "\n");
					if (this.m_UberTextRendering.GetTextMeshBounds().size.y > height)
					{
						this.m_Ellipsized = true;
						string text8 = " ...";
						if (text6 != null)
						{
							text8 += text6;
						}
						stringBuilder3.Append(text8);
						break;
					}
				}
				if (stringBuilder3.Length > 2 && stringBuilder3.ToString().EndsWith("[d]"))
				{
					stringBuilder3.Append('-');
				}
				if (stringBuilder3.Length > 0)
				{
					stringBuilder3.Append('\n');
				}
				num5++;
				stringBuilder3.Append(text5.TrimStart(new char[]
				{
					' '
				}));
				stringBuilder4.Length = 0;
				for (int j = 0; j < this.m_LineCount; j++)
				{
					stringBuilder4.Append("\n");
				}
				stringBuilder4.Append(value2);
			}
		}
		this.m_UberTextRendering.SetTextMeshGameObjectParent(transformBackup.Parent);
		this.m_UberTextRendering.SetTextMeshGameObjectRotation(transformBackup.Rotation);
		this.m_UberTextRendering.SetTextMeshGameObjectPosition(transformBackup.Position);
		this.m_UberTextRendering.SetTextMeshGameObjectLocalScale(transformBackup.LocalScale);
		this.m_UberTextRendering.SetTextAnchor(textAnchor);
		string text9;
		if (this.m_RichText)
		{
			text9 = UberText.RemoveLineBreakTagsHardSpace(stringBuilder3.ToString());
		}
		else
		{
			text9 = stringBuilder3.ToString();
		}
		if (text9 == null)
		{
			Debug.LogWarning("UberText: Word Wrap returned a null string!");
			text9 = string.Empty;
		}
		this.m_LineCount = UberText.LineCount(text9);
		return text9;
	}

	// Token: 0x0600885B RID: 34907 RVA: 0x002CB61C File Offset: 0x002C981C
	private string[] ForceSplitLargeWords(string[] words, float width, bool ellipsis)
	{
		if ((this.m_ResizeToFit && !ellipsis) || !this.m_ForceWrapLargeWords)
		{
			return words;
		}
		List<string> list = new List<string>();
		foreach (string text in words)
		{
			if (!string.IsNullOrEmpty(text))
			{
				this.m_UberTextRendering.SetText(text);
				float x = this.m_UberTextRendering.GetTextMeshBounds().size.x;
				if (x < width)
				{
					list.Add(text);
				}
				else
				{
					this.m_forceLargeWrapRichTextString.Clear();
					this.m_forceLargeWrapTestString.Clear();
					int num = Mathf.CeilToInt(x / width);
					int num2 = 0;
					int j = 0;
					while (j < num)
					{
						do
						{
							if (num2 < text.Length && text[num2] == '<' && text.IndexOf('>', num2) != -1)
							{
								bool flag;
								bool flag2;
								do
								{
									this.m_forceLargeWrapRichTextString.Append(text[num2]);
									num2++;
									flag = (num2 > 0 && text[num2 - 1] == '>');
									flag2 = (num2 < text.Length - 1 && text[num2] == '<');
								}
								while (!flag || flag2);
							}
							if (num2 < text.Length)
							{
								this.m_forceLargeWrapRichTextString.Append(text[num2]);
								this.m_forceLargeWrapTestString.Append(text[num2]);
							}
							this.m_UberTextRendering.SetText(this.m_forceLargeWrapTestString.ToString());
							Bounds textMeshBounds = this.m_UberTextRendering.GetTextMeshBounds();
							num2++;
							if (textMeshBounds.size.x > width)
							{
								goto Block_9;
							}
						}
						while (num2 < text.Length);
						IL_1AB:
						list.Add(this.m_forceLargeWrapRichTextString.ToString());
						this.m_forceLargeWrapRichTextString.Clear();
						this.m_forceLargeWrapTestString.Clear();
						j++;
						continue;
						Block_9:
						StringBuilder forceLargeWrapRichTextString = this.m_forceLargeWrapRichTextString;
						int length = forceLargeWrapRichTextString.Length;
						forceLargeWrapRichTextString.Length = length - 1;
						num2--;
						goto IL_1AB;
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600885C RID: 34908 RVA: 0x002CB820 File Offset: 0x002C9A20
	private string ProcessText(string text)
	{
		if (!this.m_RichText)
		{
			return text;
		}
		if (!this.m_WordWrap)
		{
			text = UberText.RemoveLineBreakTagsHardSpace(text);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<material=1></material>");
		stringBuilder.Append(text);
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == '<' && i <= text.Length - 2)
			{
				if (text[i + 1] == 'b')
				{
					if (i + 4 >= text.Length || text[i + 3] != '<' || text[i + 4] != '/')
					{
						this.Bold();
						stringBuilder.Replace("<b>", "<material=1>");
						stringBuilder.Replace("</b>", "</material>");
						i++;
					}
				}
				else if (text[i + 1] == 'm' && i <= text.Length - 3 && text[i + 2] != 'a')
				{
					int num = text.Substring(i).IndexOf('>');
					if (num < 1)
					{
						i++;
					}
					else
					{
						string text2 = text.Substring(i, num + 1);
						stringBuilder.Replace(text2, this.InlineImage(text2));
					}
				}
			}
		}
		string text3 = stringBuilder.ToString();
		if (text3 == null)
		{
			Debug.LogWarning("UberText: ProcessText returned a null string!");
			text3 = string.Empty;
		}
		return text3;
	}

	// Token: 0x0600885D RID: 34909 RVA: 0x002CB96D File Offset: 0x002C9B6D
	private string LocalizationFixes(string text)
	{
		if (Localization.GetLocale() == Locale.thTH)
		{
			return this.FixThai(text);
		}
		return text;
	}

	// Token: 0x0600885E RID: 34910 RVA: 0x002CB984 File Offset: 0x002C9B84
	private void SetupShadow()
	{
		if (!this.m_Shadow)
		{
			this.m_UberTextRenderToTexture.RemoveShadow();
			return;
		}
		float num = -this.m_ShadowOffset * 0.01f;
		float y = this.m_ShadowDepthOffset * 0.01f;
		this.m_UberTextRenderToTexture.InitShadow(base.gameObject, new Vector3(num, y, num));
		this.m_UberTextRenderToTexture.SetShadowColor(this.m_ShadowColor);
		this.m_UberTextRenderToTexture.SetShadowOffset(this.m_ShadowBlur);
	}

	// Token: 0x0600885F RID: 34911 RVA: 0x002CB9FC File Offset: 0x002C9BFC
	private void UpdateOutlineProperties()
	{
		if (this.m_Outline)
		{
			Vector2 vector = this.TexelSize(this.m_UberTextRendering.GetFontTexture());
			float num = this.m_OutlineSize * this.m_OutlineModifier * UberTextLocalization.GetOutlineModifier(this.m_LocalizedSettings);
			this.m_UberTextRendering.SetOutlineOffset(vector * num);
			this.m_UberTextRendering.SetOutlineBoldOffset(vector * (num + this.m_BoldSize * 0.75f));
			this.m_UberTextRendering.SetTexelSize(vector);
			this.m_UberTextRendering.SetTextColor(this.m_TextColor);
			this.m_UberTextRendering.SetOutlineColor(this.m_OutlineColor);
		}
	}

	// Token: 0x06008860 RID: 34912 RVA: 0x002CBAA0 File Offset: 0x002C9CA0
	private void Bold()
	{
		if (!this.m_HasBoldText)
		{
			this.m_HasBoldText = true;
			if (this.m_BoldSize > 10f)
			{
				this.m_BoldSize = 10f;
			}
			Vector2 a = this.TexelSize(this.m_UberTextRendering.GetFontTexture());
			this.m_UberTextRendering.SetBoldOffset(a * this.m_BoldSize);
		}
	}

	// Token: 0x06008861 RID: 34913 RVA: 0x002CBB00 File Offset: 0x002C9D00
	private string InlineImage(string tag)
	{
		if (tag == string.Empty)
		{
			return "";
		}
		this.m_UberTextRendering.SetInlineImageEnabled(true);
		int inlineImageMaterialIndex = this.m_UberTextRendering.GetInlineImageMaterialIndex();
		uint num = <PrivateImplementationDetails>.ComputeStringHash(tag);
		float num2;
		float num3;
		if (num <= 2003353461U)
		{
			if (num <= 1969945318U)
			{
				if (num != 210963988U)
				{
					if (num != 1969651128U)
					{
						if (num == 1969945318U)
						{
							if (tag == "<m6>")
							{
								num2 = 0.5f;
								num3 = 0.5f;
								goto IL_2D8;
							}
						}
					}
					else if (tag == "<m0>")
					{
						num2 = 0f;
						num3 = 0.75f;
						goto IL_2D8;
					}
				}
				else if (tag == "<m>")
				{
					num2 = 0f;
					num3 = 0f;
					goto IL_2D8;
				}
			}
			else if (num != 1970931056U)
			{
				if (num != 2003059271U)
				{
					if (num == 2003353461U)
					{
						if (tag == "<m1>")
						{
							num2 = 0.25f;
							num3 = 0.75f;
							goto IL_2D8;
						}
					}
				}
				else if (tag == "<m3>")
				{
					num2 = 0.75f;
					num3 = 0.75f;
					goto IL_2D8;
				}
			}
			else if (tag == "<m8>")
			{
				num2 = 0f;
				num3 = 0.25f;
				goto IL_2D8;
			}
		}
		else if (num <= 4116789002U)
		{
			if (num != 2011827745U)
			{
				if (num != 3303696831U)
				{
					if (num == 4116789002U)
					{
						if (tag == "<m2>")
						{
							num2 = 0.5f;
							num3 = 0.75f;
							goto IL_2D8;
						}
					}
				}
				else if (tag == "<m10>")
				{
					num2 = 0.5f;
					num3 = 0.25f;
					goto IL_2D8;
				}
			}
			else if (tag == "<me>")
			{
				num2 = 0.75f;
				num3 = 0.25f;
				goto IL_2D8;
			}
		}
		else if (num <= 4151182883U)
		{
			if (num != 4117774740U)
			{
				if (num == 4151182883U)
				{
					if (tag == "<m7>")
					{
						num2 = 0.75f;
						num3 = 0.5f;
						goto IL_2D8;
					}
				}
			}
			else if (tag == "<m4>")
			{
				num2 = 0f;
				num3 = 0.5f;
				goto IL_2D8;
			}
		}
		else if (num != 4151477073U)
		{
			if (num == 4152168621U)
			{
				if (tag == "<m9>")
				{
					num2 = 0.25f;
					num3 = 0.25f;
					goto IL_2D8;
				}
			}
		}
		else if (tag == "<m5>")
		{
			num2 = 0.25f;
			num3 = 0.5f;
			goto IL_2D8;
		}
		return tag;
		IL_2D8:
		return string.Format("<quad material={0} size={1} x={2} y={3} width=0.25 height=0.25 />", new object[]
		{
			inlineImageMaterialIndex,
			this.m_FontSize,
			num2,
			num3
		});
	}

	// Token: 0x06008862 RID: 34914 RVA: 0x002CBE1E File Offset: 0x002CA01E
	public void EnablePopupRendering(PopupCamera popupCamera)
	{
		this.m_popupCamera = popupCamera;
		this.m_meshReadyTracker.RegisterSetListener(new Action<object>(this.ApplyPopupRendering), null, true, false);
	}

	// Token: 0x06008863 RID: 34915 RVA: 0x002CBE41 File Offset: 0x002CA041
	public void DisablePopupRendering()
	{
		this.m_popupCamera = null;
		this.m_meshReadyTracker.RemoveSetListener(new Action<object>(this.ApplyPopupRendering));
		this.RemovePopupRendering();
	}

	// Token: 0x06008864 RID: 34916 RVA: 0x0001F56D File Offset: 0x0001D76D
	public bool ShouldPropagatePopupRendering()
	{
		return false;
	}

	// Token: 0x06008865 RID: 34917 RVA: 0x002CBE68 File Offset: 0x002CA068
	private void ApplyPopupRendering(object unused)
	{
		if (this.m_UberTextRendering.GetTextMeshRenderer() != null && this.m_popupCamera != null)
		{
			GameObject gameObject = base.gameObject;
			if (!this.m_popupRenderingEnabled)
			{
				this.m_originalLayerBeforePopupRendering = gameObject.layer;
				gameObject.layer = 29;
				this.UpdateLayers();
			}
			this.m_popupRenderingEnabled = true;
			PopupRenderer popupRenderer = this.m_UberTextRendering.GetPopupRenderer();
			if (popupRenderer)
			{
				popupRenderer.EnablePopupRendering(this.m_popupCamera);
			}
			PopupRenderer popupRenderer2 = this.m_UberTextRenderToTexture.GetPopupRenderer();
			if (popupRenderer2)
			{
				popupRenderer2.EnablePopupRendering(this.m_popupCamera);
			}
		}
	}

	// Token: 0x06008866 RID: 34918 RVA: 0x002CBF08 File Offset: 0x002CA108
	private void RemovePopupRendering()
	{
		if (this.m_UberTextRendering == null)
		{
			return;
		}
		if (this.m_UberTextRendering.GetTextMeshRenderer() != null)
		{
			this.m_popupRenderingEnabled = false;
			base.gameObject.layer = this.m_originalLayerBeforePopupRendering;
			this.UpdateLayers();
			this.m_UberTextRendering.DisablePopupRenderer();
			this.m_UberTextRenderToTexture.DisablePopupRenderer();
		}
	}

	// Token: 0x06008867 RID: 34919 RVA: 0x002CBF65 File Offset: 0x002CA165
	public static void DisableCache()
	{
		UberText.s_disableCache = true;
		UberText.s_CachedText.Clear();
	}

	// Token: 0x06008868 RID: 34920 RVA: 0x002CBF78 File Offset: 0x002CA178
	private void SetWorldWidthAndHeight()
	{
		float width = this.GetWidth();
		float height = this.GetHeight();
		Quaternion rotation = base.transform.rotation;
		base.transform.rotation = Quaternion.identity;
		Vector3 lossyScale = base.transform.lossyScale;
		float worldWidth = width;
		if (lossyScale.x > 0f)
		{
			worldWidth = width * lossyScale.x;
		}
		float worldHeight = height;
		if (lossyScale.y > 0f)
		{
			worldHeight = height * lossyScale.y;
		}
		base.transform.rotation = rotation;
		this.m_WorldWidth = worldWidth;
		this.m_WorldHeight = worldHeight;
	}

	// Token: 0x06008869 RID: 34921 RVA: 0x002CC00C File Offset: 0x002CA20C
	public static Vector3 GetWorldScale(Transform xform)
	{
		Vector3 localScale = xform.localScale;
		if (xform.parent != null)
		{
			Transform parent = xform.parent;
			while (parent != null)
			{
				localScale.Scale(parent.localScale);
				parent = parent.parent;
			}
		}
		return localScale;
	}

	// Token: 0x0600886A RID: 34922 RVA: 0x002CC058 File Offset: 0x002CA258
	private Vector3 GetLossyWorldScale(Transform xform)
	{
		Quaternion rotation = xform.rotation;
		xform.rotation = Quaternion.identity;
		Vector3 lossyScale = base.transform.lossyScale;
		xform.rotation = rotation;
		return lossyScale;
	}

	// Token: 0x0600886B RID: 34923 RVA: 0x002CC08C File Offset: 0x002CA28C
	private Vector2Int CalcTextureSize()
	{
		float width = this.GetWidth();
		float height = this.GetHeight();
		Vector2 vector = new Vector2((float)this.m_Resolution, (float)this.m_Resolution);
		if (width > height)
		{
			vector.x = (float)this.m_Resolution;
			vector.y = (float)this.m_Resolution * (height / width);
		}
		else
		{
			vector.x = (float)this.m_Resolution * (width / height);
			vector.y = (float)this.m_Resolution;
		}
		GraphicsManager graphicsManager;
		if (HearthstoneServices.TryGet<GraphicsManager>(out graphicsManager) && graphicsManager.RenderQualityLevel == GraphicsQuality.Low)
		{
			vector.x *= 0.75f;
			vector.y *= 0.75f;
		}
		return new Vector2Int((int)vector.x, (int)vector.y);
	}

	// Token: 0x0600886C RID: 34924 RVA: 0x002CC148 File Offset: 0x002CA348
	private string RemoveTagsFromWord(string word, out string trailingTag)
	{
		trailingTag = null;
		if (!this.m_RichText)
		{
			return word;
		}
		if (!word.Contains("<") && !word.Contains("["))
		{
			return word;
		}
		StringBuilder stringBuilder = new StringBuilder(0, word.Length);
		bool flag = false;
		for (int i = 0; i < word.Length; i++)
		{
			if (word[i] == '<')
			{
				if (i < word.Length - 1)
				{
					if (word[i + 1] == 'q')
					{
						if (!word.Substring(i).Contains(">"))
						{
							return stringBuilder.ToString();
						}
						int num = i + 1;
						while (word[num] != '>')
						{
							num++;
						}
						stringBuilder.Append("W");
						i = num;
					}
					else
					{
						flag = true;
						if (i != 0 && trailingTag == null)
						{
							trailingTag = word.Substring(i);
						}
					}
				}
			}
			else if (word[i] == '>')
			{
				flag = false;
			}
			else if (word[i] == '[' && i + 2 < word.Length && UberText.IsValidSquareBracketTag(word[i + 1]) && word[i + 2] == ']')
			{
				flag = true;
			}
			else
			{
				if (word[i] == ']')
				{
					if (i - 2 >= 0 && UberText.IsValidSquareBracketTag(word[i - 1]) && word[i - 2] == '[')
					{
						flag = false;
						goto IL_14F;
					}
					flag = false;
				}
				if (!flag)
				{
					stringBuilder.Append(word[i]);
				}
			}
			IL_14F:;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600886D RID: 34925 RVA: 0x002CC2BC File Offset: 0x002CA4BC
	private static string RemoveLineBreakTagsHardSpace(string text)
	{
		StringBuilder stringBuilder = new StringBuilder(text.Length, text.Length);
		bool flag = false;
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == '[' && i + 2 < text.Length && UberText.IsValidSquareBracketTag(text[i + 1]) && text[i + 2] == ']')
			{
				flag = true;
			}
			else
			{
				if (text[i] == ']')
				{
					if (i - 2 >= 0 && UberText.IsValidSquareBracketTag(text[i - 1]) && text[i - 2] == '[')
					{
						flag = false;
						goto IL_AD;
					}
					flag = false;
				}
				if (!flag)
				{
					if (text[i] == '_')
					{
						stringBuilder.Append(' ');
					}
					else
					{
						stringBuilder.Append(text[i]);
					}
				}
			}
			IL_AD:;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600886E RID: 34926 RVA: 0x002CC38C File Offset: 0x002CA58C
	private static bool IsValidSquareBracketTag(char ch)
	{
		return ch == 'b' || ch == 'd' || ch == 'x';
	}

	// Token: 0x0600886F RID: 34927 RVA: 0x002CC3A0 File Offset: 0x002CA5A0
	private static bool IsWhitespaceOrUnderscore(char ch)
	{
		switch (ch)
		{
		case '\t':
		case '\n':
		case '\r':
			break;
		case '\v':
		case '\f':
			return false;
		default:
			if (ch != ' ' && ch != '_')
			{
				return false;
			}
			break;
		}
		return true;
	}

	// Token: 0x06008870 RID: 34928 RVA: 0x002CC3CC File Offset: 0x002CA5CC
	public static string RemoveMarkupAndCollapseWhitespaces(string text)
	{
		if (text == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = null;
		int num = 0;
		int num2 = 0;
		int num3 = text.IndexOfAny(UberText.STRIP_CHARS_INDEX_OF_ANY, num2);
		while (num3 >= 0 && num3 < text.Length)
		{
			num2 = num3 + 1;
			if ((text[num3] != ' ' || (num3 + 1 < text.Length && UberText.IsWhitespaceOrUnderscore(text[num3 + 1]))) && (text[num3] != '[' || (num3 + 2 < text.Length && UberText.IsValidSquareBracketTag(text[num3 + 1]) && text[num3 + 2] == ']')))
			{
				if (num3 > num)
				{
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					string value = text.Substring(num, num3 - num);
					stringBuilder.Append(value);
				}
				if (UberText.IsWhitespaceOrUnderscore(text[num3]))
				{
					while (num2 < text.Length && UberText.IsWhitespaceOrUnderscore(text[num2]))
					{
						num2++;
					}
					if ((text[num3] != '\n' && text[num3] != '\r') || num3 <= 0 || text[num3 - 1] != '-')
					{
						if (stringBuilder == null)
						{
							stringBuilder = new StringBuilder();
						}
						stringBuilder.Append(' ');
					}
					num = num2;
				}
				else
				{
					char value2 = (text[num3] == '<') ? '>' : ']';
					int num4 = text.IndexOf(value2, num2);
					if (num4 < 0)
					{
						num2 = text.Length;
						num = num2;
						break;
					}
					num2 = num4 + 1;
					num = num2;
				}
			}
			num3 = text.IndexOfAny(UberText.STRIP_CHARS_INDEX_OF_ANY, num2);
		}
		if (num < text.Length && num > 0)
		{
			stringBuilder.Append(text.Substring(num));
		}
		if (stringBuilder != null)
		{
			return stringBuilder.ToString();
		}
		if (num == 0)
		{
			return text;
		}
		return string.Empty;
	}

	// Token: 0x06008871 RID: 34929 RVA: 0x002CC573 File Offset: 0x002CA773
	private void CleanUp()
	{
		this.m_Offset = 0f;
		if (this.m_UberTextRendering != null)
		{
			this.m_UberTextRendering.Destroy();
		}
		if (this.m_UberTextRenderToTexture != null)
		{
			this.m_UberTextRenderToTexture.Destroy();
		}
		this.m_updated = false;
	}

	// Token: 0x06008872 RID: 34930 RVA: 0x002CC5B0 File Offset: 0x002CA7B0
	private static int LineCount(string s)
	{
		int num = 1;
		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] == '\n')
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06008873 RID: 34931 RVA: 0x002CC5E0 File Offset: 0x002CA7E0
	private int ConvertStringCharToUtf32(string str, int index)
	{
		int num = -1;
		if (!UberText.s_charUtf32Map.TryGetValue(str, out num))
		{
			num = char.ConvertToUtf32(str, index);
			UberText.s_charUtf32Map.Add(str, num);
		}
		return num;
	}

	// Token: 0x06008874 RID: 34932 RVA: 0x002CC614 File Offset: 0x002CA814
	private string[] BreakStringIntoWords(string text)
	{
		if (text == null || text == string.Empty)
		{
			return null;
		}
		UberText.s_wordBuilder.Length = 0;
		UberText.s_wordList.Clear();
		UberText.s_wordCharList.Clear();
		bool flag = false;
		TextElementEnumerator textElementEnumerator = StringInfo.GetTextElementEnumerator(text);
		while (textElementEnumerator.MoveNext())
		{
			UberText.s_wordCharList.Add(textElementEnumerator.GetTextElement());
		}
		bool flag2 = false;
		UberText.s_wordBuilder.Append(UberText.s_wordCharList[0]);
		if (UberText.s_wordCharList[0] == "<" && this.m_RichText)
		{
			flag = true;
		}
		int i = 1;
		while (i < UberText.s_wordCharList.Count)
		{
			if (!(UberText.s_wordCharList[i] == "]") || i - 2 <= 0)
			{
				goto IL_170;
			}
			if ((UberText.s_wordCharList[i - 1] == "b" || UberText.s_wordCharList[i - 1] == "d") && UberText.s_wordCharList[i - 2] == "[")
			{
				UberText.s_wordBuilder.Append(UberText.s_wordCharList[i]);
				UberText.s_wordList.Add(UberText.s_wordBuilder.ToString());
				UberText.s_wordBuilder.Length = 0;
			}
			else
			{
				if (UberText.s_wordCharList[i - 1] == "x" && UberText.s_wordCharList[i - 2] == "[")
				{
					flag2 = true;
					goto IL_170;
				}
				goto IL_170;
			}
			IL_2B6:
			i++;
			continue;
			IL_170:
			if (UberText.s_wordCharList[i] == "<" && this.m_RichText)
			{
				flag = true;
				UberText.s_wordBuilder.Append(UberText.s_wordCharList[i]);
				goto IL_2B6;
			}
			if (UberText.s_wordCharList[i] == ">")
			{
				flag = false;
				UberText.s_wordBuilder.Append(UberText.s_wordCharList[i]);
				goto IL_2B6;
			}
			if (flag)
			{
				UberText.s_wordBuilder.Append(UberText.s_wordCharList[i]);
				goto IL_2B6;
			}
			string text2 = UberText.s_wordCharList[i - 1];
			string text3 = UberText.s_wordCharList[i];
			string text4 = string.Empty;
			if (i < UberText.s_wordCharList.Count - 1)
			{
				text4 = UberText.s_wordCharList[i + 1];
			}
			int lastChar = this.ConvertStringCharToUtf32(text2, 0);
			int wideChar = this.ConvertStringCharToUtf32(text3, 0);
			int nextChar = 0;
			if (!string.IsNullOrEmpty(text4))
			{
				nextChar = this.ConvertStringCharToUtf32(text4, 0);
			}
			if (!flag2 && this.CanWrapBetween(lastChar, wideChar, nextChar, text2, text3))
			{
				UberText.s_wordList.Add(UberText.s_wordBuilder.ToString());
				UberText.s_wordBuilder.Length = 0;
			}
			UberText.s_wordBuilder.Append(UberText.s_wordCharList[i]);
			goto IL_2B6;
		}
		UberText.s_wordList.Add(UberText.s_wordBuilder.ToString());
		return UberText.s_wordList.ToArray();
	}

	// Token: 0x06008875 RID: 34933 RVA: 0x002CC90C File Offset: 0x002CAB0C
	public Vector2 TexelSize(Texture texture)
	{
		if (!texture)
		{
			return Vector2.zero;
		}
		int frameCount = Time.frameCount;
		Font key = this.m_Font;
		if (this.m_LocalizedFont != null)
		{
			key = this.m_LocalizedFont;
		}
		if (UberText.s_TexelUpdateFrame.ContainsKey(key) && UberText.s_TexelUpdateFrame[key] == frameCount)
		{
			return UberText.s_TexelUpdateData[key];
		}
		Vector2 vector = default(Vector2);
		vector.x = 1f / (float)texture.width;
		vector.y = 1f / (float)texture.height;
		UberText.s_TexelUpdateFrame[key] = frameCount;
		UberText.s_TexelUpdateData[key] = vector;
		return vector;
	}

	// Token: 0x06008876 RID: 34934 RVA: 0x002CC9BC File Offset: 0x002CABBC
	private static void DeleteOldCacheFiles()
	{
		foreach (object obj in Enum.GetValues(typeof(Locale)))
		{
			Locale locale = (Locale)obj;
			string text = string.Format("{0}/text_{1}.cache", FileUtils.PersistentDataPath, locale);
			if (File.Exists(text))
			{
				try
				{
					File.Delete(text);
				}
				catch (Exception ex)
				{
					Debug.LogError(string.Format("UberText.DeleteOldCacheFiles() - Failed to delete {0}. Reason={1}", text, ex.Message));
				}
			}
		}
	}

	// Token: 0x06008877 RID: 34935 RVA: 0x002CCA68 File Offset: 0x002CAC68
	private static string GetCacheFolderPath()
	{
		return string.Format("{0}/UberText", FileUtils.CachePath);
	}

	// Token: 0x06008878 RID: 34936 RVA: 0x002CCA79 File Offset: 0x002CAC79
	private static string GetCacheFilePath()
	{
		return string.Format("{0}/text_{1}.cache", UberText.GetCacheFolderPath(), Localization.GetLocale());
	}

	// Token: 0x06008879 RID: 34937 RVA: 0x002CCA94 File Offset: 0x002CAC94
	private static void CreateCacheFolder()
	{
		string cacheFolderPath = UberText.GetCacheFolderPath();
		if (Directory.Exists(cacheFolderPath))
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(cacheFolderPath);
		}
		catch (Exception ex)
		{
			Debug.LogError(string.Format("UberText.CreateCacheFolder() - Failed to create {0}. Reason={1}", cacheFolderPath, ex.Message));
		}
	}

	// Token: 0x0600887A RID: 34938 RVA: 0x002CCAE4 File Offset: 0x002CACE4
	public static void StoreCachedData()
	{
		if (UberText.s_disableCache)
		{
			return;
		}
		UberText.CreateCacheFolder();
		string cacheFilePath = UberText.GetCacheFilePath();
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(cacheFilePath, FileMode.Create)))
		{
			int value = 65614;
			binaryWriter.Write(value);
			foreach (KeyValuePair<int, UberText.CachedTextValues> keyValuePair in UberText.s_CachedText)
			{
				binaryWriter.Write(keyValuePair.Key);
				binaryWriter.Write(keyValuePair.Value.m_Text);
				binaryWriter.Write(keyValuePair.Value.m_CharSize);
				binaryWriter.Write(keyValuePair.Value.m_OriginalTextHash);
			}
		}
		Log.UberText.Print("UberText Cache Stored: " + cacheFilePath, Array.Empty<object>());
	}

	// Token: 0x0600887B RID: 34939 RVA: 0x002CCBD4 File Offset: 0x002CADD4
	public static IEnumerator<IAsyncJobResult> Job_LoadCachedData()
	{
		if (UberText.s_disableCache)
		{
			yield break;
		}
		UberText.s_CachedText.Clear();
		UberText.DeleteOldCacheFiles();
		UberText.CreateCacheFolder();
		string cacheFilePath = UberText.GetCacheFilePath();
		if (!File.Exists(cacheFilePath))
		{
			yield break;
		}
		int num = 65614;
		try
		{
			using (BinaryReader binaryReader = new BinaryReader(File.Open(cacheFilePath, FileMode.Open)))
			{
				if (binaryReader.BaseStream.Length == 0L)
				{
					yield break;
				}
				if (binaryReader.ReadInt32() != num)
				{
					yield break;
				}
				if (binaryReader.PeekChar() == -1)
				{
					yield break;
				}
				while (binaryReader.PeekChar() != -1)
				{
					int key = binaryReader.ReadInt32();
					UberText.CachedTextValues cachedTextValues = new UberText.CachedTextValues();
					cachedTextValues.m_Text = binaryReader.ReadString();
					cachedTextValues.m_CharSize = binaryReader.ReadSingle();
					cachedTextValues.m_OriginalTextHash = binaryReader.ReadInt32();
					UberText.s_CachedText.Add(key, cachedTextValues);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(string.Format("UberText LoadCachedData() failed: {0}", ex.Message));
			UberText.s_CachedText.Clear();
		}
		if (UberText.s_CachedText.Count > 50000)
		{
			UberText.s_CachedText.Clear();
		}
		Log.UberText.Print("UberText Cache Loaded: " + UberText.s_CachedText.Count.ToString(), Array.Empty<object>());
		yield break;
	}

	// Token: 0x0600887C RID: 34940 RVA: 0x002CCBDC File Offset: 0x002CADDC
	private bool CanWrapBetween(int lastChar, int wideChar, int nextChar, string lastCharStr, string wideCharStr)
	{
		if (Localization.GetLocale() == Locale.frFR || Localization.GetLocale() == Locale.deDE)
		{
			if (char.IsWhiteSpace(wideCharStr, 0))
			{
				if (nextChar <= 59)
				{
					if (nextChar != 33 && nextChar != 46 && nextChar - 58 > 1)
					{
						goto IL_49;
					}
				}
				else if (nextChar != 63 && nextChar != 171 && nextChar != 187)
				{
					goto IL_49;
				}
				return false;
			}
			IL_49:
			if (char.IsWhiteSpace(wideCharStr, 0) && lastChar == 171)
			{
				return false;
			}
		}
		if (lastChar == 45)
		{
			return wideChar < 48 || wideChar > 57;
		}
		if (lastChar == 59)
		{
			return true;
		}
		if (wideChar == 124)
		{
			return true;
		}
		if (char.IsWhiteSpace(lastCharStr, 0))
		{
			return false;
		}
		if (char.IsWhiteSpace(wideCharStr, 0))
		{
			return true;
		}
		if (lastChar <= 12304)
		{
			if (lastChar <= 123)
			{
				if (lastChar <= 40)
				{
					if (lastChar != 36 && lastChar != 40)
					{
						goto IL_1BC;
					}
				}
				else if (lastChar - 91 > 1 && lastChar != 123)
				{
					goto IL_1BC;
				}
			}
			else if (lastChar <= 8220)
			{
				if (lastChar != 8216 && lastChar != 8220)
				{
					goto IL_1BC;
				}
			}
			else if (lastChar != 8245)
			{
				switch (lastChar)
				{
				case 12296:
				case 12298:
				case 12300:
				case 12302:
				case 12304:
					break;
				case 12297:
				case 12299:
				case 12301:
				case 12303:
					goto IL_1BC;
				default:
					goto IL_1BC;
				}
			}
		}
		else if (lastChar <= 65284)
		{
			if (lastChar <= 12317)
			{
				if (lastChar != 12308 && lastChar != 12317)
				{
					goto IL_1BC;
				}
			}
			else
			{
				switch (lastChar)
				{
				case 65113:
				case 65115:
				case 65117:
					break;
				case 65114:
				case 65116:
					goto IL_1BC;
				default:
					if (lastChar != 65284)
					{
						goto IL_1BC;
					}
					break;
				}
			}
		}
		else if (lastChar <= 65339)
		{
			if (lastChar != 65288 && lastChar != 65339)
			{
				goto IL_1BC;
			}
		}
		else if (lastChar != 65371 && lastChar != 65505 && lastChar - 65509 > 1)
		{
			goto IL_1BC;
		}
		return false;
		IL_1BC:
		if (wideChar <= 8451)
		{
			if (wideChar <= 125)
			{
				if (wideChar <= 44)
				{
					if (wideChar <= 37)
					{
						if (wideChar != 33 && wideChar != 37)
						{
							goto IL_437;
						}
					}
					else if (wideChar != 41 && wideChar != 44)
					{
						goto IL_437;
					}
				}
				else if (wideChar <= 59)
				{
					if (wideChar != 46 && wideChar - 58 > 1)
					{
						goto IL_437;
					}
				}
				else if (wideChar != 63 && wideChar != 93 && wideChar != 125)
				{
					goto IL_437;
				}
			}
			else if (wideChar <= 8217)
			{
				if (wideChar <= 183)
				{
					if (wideChar != 176 && wideChar != 183)
					{
						goto IL_437;
					}
				}
				else if (wideChar - 8211 > 1 && wideChar != 8217)
				{
					goto IL_437;
				}
			}
			else if (wideChar <= 8226)
			{
				if (wideChar != 8221 && wideChar != 8226)
				{
					goto IL_437;
				}
			}
			else if (wideChar - 8230 > 1 && wideChar - 8242 > 1 && wideChar != 8451)
			{
				goto IL_437;
			}
		}
		else if (wideChar <= 65285)
		{
			if (wideChar <= 12318)
			{
				if (wideChar <= 12305)
				{
					if (wideChar - 12289 > 1)
					{
						switch (wideChar)
						{
						case 12297:
						case 12299:
						case 12301:
						case 12303:
						case 12305:
							break;
						case 12298:
						case 12300:
						case 12302:
						case 12304:
							goto IL_437;
						default:
							goto IL_437;
						}
					}
				}
				else if (wideChar != 12309 && wideChar != 12318)
				{
					goto IL_437;
				}
			}
			else if (wideChar <= 65072)
			{
				if (wideChar != 12540 && wideChar != 65072)
				{
					goto IL_437;
				}
			}
			else
			{
				switch (wideChar)
				{
				case 65104:
				case 65105:
				case 65106:
				case 65108:
				case 65109:
				case 65110:
				case 65111:
				case 65114:
				case 65116:
				case 65118:
					break;
				case 65107:
				case 65112:
				case 65113:
				case 65115:
				case 65117:
					goto IL_437;
				default:
					if (wideChar != 65281 && wideChar != 65285)
					{
						goto IL_437;
					}
					break;
				}
			}
		}
		else if (wideChar <= 65311)
		{
			if (wideChar <= 65292)
			{
				if (wideChar != 65289 && wideChar != 65292)
				{
					goto IL_437;
				}
			}
			else if (wideChar != 65294 && wideChar - 65306 > 1 && wideChar != 65311)
			{
				goto IL_437;
			}
		}
		else if (wideChar <= 65373)
		{
			if (wideChar != 65341 && wideChar != 65373)
			{
				goto IL_437;
			}
		}
		else if (wideChar != 65392 && wideChar - 65438 > 1 && wideChar != 65504)
		{
			goto IL_437;
		}
		return false;
		IL_437:
		return lastChar == 12290 || lastChar == 65292 || ((Localization.GetLocale() != Locale.koKR || this.m_Alignment != UberText.AlignmentOptions.Center) && ((wideChar >= 4352 && wideChar <= 4607) || (wideChar >= 12288 && wideChar <= 55215) || (wideChar >= 63744 && wideChar <= 64255) || (wideChar >= 65280 && wideChar <= 65439) || (wideChar >= 65440 && wideChar <= 65500)));
	}

	// Token: 0x0600887D RID: 34941 RVA: 0x002CD098 File Offset: 0x002CB298
	private string FixThai(string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		char[] array = text.ToCharArray();
		UberText.ThaiGlyphType[] array2 = new UberText.ThaiGlyphType[array.Count<char>()];
		StringBuilder stringBuilder = new StringBuilder(text);
		for (int i = 0; i < array.Count<char>(); i++)
		{
			char c = array[i];
			if ((c >= 'ก' && c <= 'ฯ') || c == 'ะ' || c == 'เ' || c == 'แ')
			{
				if (c == 'ฝ' || c == 'ฟ' || c == 'ป' || c == 'ฬ')
				{
					array2[i] = UberText.ThaiGlyphType.BASE_ASCENDER;
				}
				else if (c == 'ฏ' || c == 'ฎ')
				{
					array2[i] = UberText.ThaiGlyphType.BASE_DESCENDER;
				}
				else
				{
					array2[i] = UberText.ThaiGlyphType.BASE;
				}
			}
			else if (c >= '่' && c <= '์')
			{
				array2[i] = UberText.ThaiGlyphType.TONE_MARK;
			}
			else if (c == 'ั' || c == 'ิ' || c == 'ี' || c == 'ึ' || c == 'ื' || c == '็' || c == 'ํ')
			{
				array2[i] = UberText.ThaiGlyphType.UPPER;
			}
			else if (c == 'ุ' || c == 'ู' || c == 'ฺ')
			{
				array2[i] = UberText.ThaiGlyphType.LOWER;
			}
		}
		for (int j = 0; j < array.Count<char>(); j++)
		{
			char c2 = array[j];
			UberText.ThaiGlyphType thaiGlyphType = array2[j];
			stringBuilder[j] = c2;
			if (j >= 1)
			{
				UberText.ThaiGlyphType thaiGlyphType2 = array2[j - 1];
				char c3 = array[j - 1];
				if (thaiGlyphType == UberText.ThaiGlyphType.UPPER && thaiGlyphType2 == UberText.ThaiGlyphType.BASE_ASCENDER)
				{
					switch (c2)
					{
					case 'ั':
						stringBuilder[j] = '';
						break;
					case 'า':
					case 'ำ':
						break;
					case 'ิ':
						stringBuilder[j] = '';
						break;
					case 'ี':
						stringBuilder[j] = '';
						break;
					case 'ึ':
						stringBuilder[j] = '';
						break;
					case 'ื':
						stringBuilder[j] = '';
						break;
					default:
						if (c2 != '็')
						{
							if (c2 == 'ํ')
							{
								stringBuilder[j] = '';
							}
						}
						else
						{
							stringBuilder[j] = '';
						}
						break;
					}
				}
				else if (thaiGlyphType == UberText.ThaiGlyphType.LOWER && thaiGlyphType2 == UberText.ThaiGlyphType.BASE_DESCENDER)
				{
					stringBuilder[j] = c2 + '';
				}
				else
				{
					if (thaiGlyphType == UberText.ThaiGlyphType.LOWER)
					{
						if (c3 == 'ญ')
						{
							stringBuilder[j - 1] = '';
							goto IL_391;
						}
						if (c3 == 'ฐ')
						{
							stringBuilder[j - 1] = '';
							goto IL_391;
						}
					}
					if (thaiGlyphType == UberText.ThaiGlyphType.TONE_MARK)
					{
						if (j - 2 >= 0)
						{
							if (thaiGlyphType2 == UberText.ThaiGlyphType.UPPER && array2[j - 2] == UberText.ThaiGlyphType.BASE_ASCENDER)
							{
								stringBuilder[j] = c2 + '';
							}
							if (thaiGlyphType2 == UberText.ThaiGlyphType.LOWER && j > 1)
							{
								thaiGlyphType2 = array2[j - 2];
								c3 = array[j - 2];
							}
						}
						if (j < array.Count<char>() - 1 && (array[j + 1] == 'ำ' || array[j + 1] == 'ํ'))
						{
							if (thaiGlyphType2 == UberText.ThaiGlyphType.BASE_ASCENDER)
							{
								stringBuilder[j] = c2 + '';
								stringBuilder.Insert(j + 1, '');
								stringBuilder.Insert(j + 2, c2);
								if (array[j + 1] == 'ำ')
								{
									stringBuilder[j + 1] = 'ำ';
								}
								j++;
								goto IL_391;
							}
						}
						else if (thaiGlyphType2 == UberText.ThaiGlyphType.BASE || thaiGlyphType2 == UberText.ThaiGlyphType.BASE_DESCENDER)
						{
							stringBuilder[j] = c2 + '';
							goto IL_391;
						}
						if (thaiGlyphType2 == UberText.ThaiGlyphType.BASE_ASCENDER)
						{
							stringBuilder[j] = c2 + '';
						}
					}
				}
			}
			IL_391:;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04006DE5 RID: 28133
	private const int CACHE_FILE_VERSION_TEMP = 2;

	// Token: 0x04006DE6 RID: 28134
	private const int CACHE_FILE_MAX_SIZE = 50000;

	// Token: 0x04006DE7 RID: 28135
	private const string FONT_NAME_BLIZZARD_GLOBAL = "BlizzardGlobal";

	// Token: 0x04006DE8 RID: 28136
	private const string FONT_NAME_BELWE_OUTLINE = "Belwe_Outline";

	// Token: 0x04006DE9 RID: 28137
	private const string FONT_NAME_BELWE = "Belwe";

	// Token: 0x04006DEA RID: 28138
	private const string FONT_NAME_FRANKLIN_GOTHIC = "FranklinGothic";

	// Token: 0x04006DEB RID: 28139
	private const float CHARACTER_SIZE_SCALE = 0.01f;

	// Token: 0x04006DEC RID: 28140
	private const float BOLD_MAX_SIZE = 10f;

	// Token: 0x04006DED RID: 28141
	private const int WORD_CHARACTER_BUFFER = 3;

	// Token: 0x04006DEE RID: 28142
	private const int MAX_RESIZE_TEXT_ITERATION_COUNT = 40;

	// Token: 0x04006DEF RID: 28143
	[SerializeField]
	private string m_Text = "Uber Text";

	// Token: 0x04006DF0 RID: 28144
	[SerializeField]
	private bool m_GameStringLookup;

	// Token: 0x04006DF1 RID: 28145
	[SerializeField]
	private bool m_UseEditorText;

	// Token: 0x04006DF2 RID: 28146
	[SerializeField]
	private float m_Width = 1f;

	// Token: 0x04006DF3 RID: 28147
	[SerializeField]
	private float m_Height = 1f;

	// Token: 0x04006DF4 RID: 28148
	[SerializeField]
	private float m_LineSpacing = 1f;

	// Token: 0x04006DF5 RID: 28149
	[SerializeField]
	private Font m_Font;

	// Token: 0x04006DF6 RID: 28150
	[SerializeField]
	private int m_FontSize = 35;

	// Token: 0x04006DF7 RID: 28151
	[SerializeField]
	private int m_MinFontSize = 10;

	// Token: 0x04006DF8 RID: 28152
	[SerializeField]
	private float m_CharacterSize = 5f;

	// Token: 0x04006DF9 RID: 28153
	[SerializeField]
	private float m_MinCharacterSize = 1f;

	// Token: 0x04006DFA RID: 28154
	[SerializeField]
	private bool m_RichText = true;

	// Token: 0x04006DFB RID: 28155
	[SerializeField]
	private Color m_TextColor = Color.white;

	// Token: 0x04006DFC RID: 28156
	[SerializeField]
	private float m_BoldSize;

	// Token: 0x04006DFD RID: 28157
	[SerializeField]
	private bool m_WordWrap;

	// Token: 0x04006DFE RID: 28158
	[SerializeField]
	private bool m_ForceWrapLargeWords;

	// Token: 0x04006DFF RID: 28159
	[SerializeField]
	private bool m_ResizeToFit;

	// Token: 0x04006E00 RID: 28160
	[SerializeField]
	private bool m_ResizeToFitAndGrow;

	// Token: 0x04006E01 RID: 28161
	[SerializeField]
	private float m_ResizeToGrowStep = 0.05f;

	// Token: 0x04006E02 RID: 28162
	[SerializeField]
	private bool m_Underwear;

	// Token: 0x04006E03 RID: 28163
	[SerializeField]
	private bool m_UnderwearFlip;

	// Token: 0x04006E04 RID: 28164
	[SerializeField]
	private float m_UnderwearWidth = 0.2f;

	// Token: 0x04006E05 RID: 28165
	[SerializeField]
	private float m_UnderwearHeight = 0.2f;

	// Token: 0x04006E06 RID: 28166
	[SerializeField]
	private UberText.AlignmentOptions m_Alignment = UberText.AlignmentOptions.Center;

	// Token: 0x04006E07 RID: 28167
	[SerializeField]
	private UberText.AnchorOptions m_Anchor = UberText.AnchorOptions.Middle;

	// Token: 0x04006E08 RID: 28168
	[SerializeField]
	private bool m_RenderToTexture;

	// Token: 0x04006E09 RID: 28169
	[SerializeField]
	private GameObject m_RenderOnObject;

	// Token: 0x04006E0A RID: 28170
	[SerializeField]
	private int m_Resolution = 256;

	// Token: 0x04006E0B RID: 28171
	[SerializeField]
	private bool m_Outline;

	// Token: 0x04006E0C RID: 28172
	[SerializeField]
	private float m_OutlineSize = 1f;

	// Token: 0x04006E0D RID: 28173
	[SerializeField]
	private Color m_OutlineColor = Color.black;

	// Token: 0x04006E0E RID: 28174
	[SerializeField]
	private bool m_AntiAlias;

	// Token: 0x04006E0F RID: 28175
	[SerializeField]
	private float m_AntiAliasAmount = 0.5f;

	// Token: 0x04006E10 RID: 28176
	[SerializeField]
	private float m_AntiAliasEdge = 0.5f;

	// Token: 0x04006E11 RID: 28177
	[SerializeField]
	private bool m_Shadow;

	// Token: 0x04006E12 RID: 28178
	[SerializeField]
	private float m_ShadowOffset = 1f;

	// Token: 0x04006E13 RID: 28179
	[SerializeField]
	private float m_ShadowDepthOffset;

	// Token: 0x04006E14 RID: 28180
	[SerializeField]
	private Color m_ShadowColor = new Color(0.1f, 0.1f, 0.1f, 0.333f);

	// Token: 0x04006E15 RID: 28181
	[SerializeField]
	private float m_ShadowBlur = 1.5f;

	// Token: 0x04006E16 RID: 28182
	[SerializeField]
	private int m_ShadowRenderQueueOffset = -1;

	// Token: 0x04006E17 RID: 28183
	[SerializeField]
	private int m_RenderQueue;

	// Token: 0x04006E18 RID: 28184
	[SerializeField]
	private float m_AmbientLightBlend;

	// Token: 0x04006E19 RID: 28185
	[SerializeField]
	private List<Material> m_AdditionalMaterials = new List<Material>();

	// Token: 0x04006E1A RID: 28186
	[SerializeField]
	private Color m_GradientUpperColor = Color.white;

	// Token: 0x04006E1B RID: 28187
	[SerializeField]
	private Color m_GradientLowerColor = Color.white;

	// Token: 0x04006E1C RID: 28188
	[SerializeField]
	private bool m_Cache = true;

	// Token: 0x04006E1D RID: 28189
	[SerializeField]
	private UberText.LocalizationSettings m_LocalizedSettings;

	// Token: 0x04006E1E RID: 28190
	private bool m_isFontDefLoaded;

	// Token: 0x04006E1F RID: 28191
	private Font m_LocalizedFont;

	// Token: 0x04006E20 RID: 28192
	private float m_LineSpaceModifier = 1f;

	// Token: 0x04006E21 RID: 28193
	private float m_SingleLineAdjustment;

	// Token: 0x04006E22 RID: 28194
	private float m_FontSizeModifier = 1f;

	// Token: 0x04006E23 RID: 28195
	private float m_CharacterSizeModifier = 1f;

	// Token: 0x04006E24 RID: 28196
	private float m_UnboundCharacterSizeModifier = 1f;

	// Token: 0x04006E25 RID: 28197
	private float m_OutlineModifier = 1f;

	// Token: 0x04006E26 RID: 28198
	private float m_WorldWidth;

	// Token: 0x04006E27 RID: 28199
	private float m_WorldHeight;

	// Token: 0x04006E28 RID: 28200
	private bool m_updated;

	// Token: 0x04006E29 RID: 28201
	private string m_PreviousText = string.Empty;

	// Token: 0x04006E2A RID: 28202
	private string[] m_Words;

	// Token: 0x04006E2B RID: 28203
	private int m_LineCount;

	// Token: 0x04006E2C RID: 28204
	private Vector2 m_PreviousTexelSize;

	// Token: 0x04006E2D RID: 28205
	private Vector2Int m_PreviousFontSize;

	// Token: 0x04006E2E RID: 28206
	private bool m_Ellipsized;

	// Token: 0x04006E2F RID: 28207
	private int m_CacheHash;

	// Token: 0x04006E30 RID: 28208
	private bool m_Hidden;

	// Token: 0x04006E31 RID: 28209
	private bool m_TextSet;

	// Token: 0x04006E32 RID: 28210
	private FlagStateTracker m_meshReadyTracker;

	// Token: 0x04006E33 RID: 28211
	private Bounds m_UnderwearLeftBounds;

	// Token: 0x04006E34 RID: 28212
	private Bounds m_UnderwearRightBounds;

	// Token: 0x04006E35 RID: 28213
	private WidgetTransform m_widgetTransform;

	// Token: 0x04006E36 RID: 28214
	private bool m_HadWidgetTransformLastCheck;

	// Token: 0x04006E37 RID: 28215
	private UberTextRendering m_UberTextRendering;

	// Token: 0x04006E38 RID: 28216
	private UberTextRenderToTexture m_UberTextRenderToTexture;

	// Token: 0x04006E39 RID: 28217
	private bool m_HasBoldText;

	// Token: 0x04006E3A RID: 28218
	private int m_CurrentLayer;

	// Token: 0x04006E3B RID: 28219
	private static float s_offset = -3000f;

	// Token: 0x04006E3C RID: 28220
	private float m_Offset;

	// Token: 0x04006E3D RID: 28221
	private readonly StringBuilder m_forceLargeWrapRichTextString = new StringBuilder();

	// Token: 0x04006E3E RID: 28222
	private readonly StringBuilder m_forceLargeWrapTestString = new StringBuilder();

	// Token: 0x04006E3F RID: 28223
	private static bool s_disableCache = false;

	// Token: 0x04006E40 RID: 28224
	private static Map<int, UberText.CachedTextValues> s_CachedText = new Map<int, UberText.CachedTextValues>();

	// Token: 0x04006E41 RID: 28225
	private static Map<Font, int> s_TexelUpdateFrame = new Map<Font, int>();

	// Token: 0x04006E42 RID: 28226
	private static Map<Font, Vector2> s_TexelUpdateData = new Map<Font, Vector2>();

	// Token: 0x04006E43 RID: 28227
	private PopupCamera m_popupCamera;

	// Token: 0x04006E44 RID: 28228
	private int m_originalLayerBeforePopupRendering;

	// Token: 0x04006E45 RID: 28229
	private bool m_popupRenderingEnabled;

	// Token: 0x04006E46 RID: 28230
	private static readonly char[] STRIP_CHARS_INDEX_OF_ANY = new char[]
	{
		'<',
		'[',
		'\\',
		' ',
		'\t',
		'\r',
		'\n',
		'_'
	};

	// Token: 0x04006E47 RID: 28231
	private static StringBuilder s_wordBuilder = new StringBuilder(128);

	// Token: 0x04006E48 RID: 28232
	private static List<string> s_wordList = new List<string>(256);

	// Token: 0x04006E49 RID: 28233
	private static List<string> s_wordCharList = new List<string>(1024);

	// Token: 0x04006E4A RID: 28234
	private static Dictionary<string, int> s_charUtf32Map = new Dictionary<string, int>(256);

	// Token: 0x02002348 RID: 9032
	[Serializable]
	public class LocalizationSettings
	{
		// Token: 0x06011C2D RID: 72749 RVA: 0x004C9CEC File Offset: 0x004C7EEC
		public LocalizationSettings()
		{
			this.m_LocaleAdjustments = new List<UberText.LocalizationSettings.LocaleAdjustment>();
		}

		// Token: 0x06011C2E RID: 72750 RVA: 0x004C9CFF File Offset: 0x004C7EFF
		public bool HasLocale(Locale locale)
		{
			return this.GetLocale(locale) != null;
		}

		// Token: 0x06011C2F RID: 72751 RVA: 0x004C9D10 File Offset: 0x004C7F10
		public UberText.LocalizationSettings.LocaleAdjustment GetLocale(Locale locale)
		{
			foreach (UberText.LocalizationSettings.LocaleAdjustment localeAdjustment in this.m_LocaleAdjustments)
			{
				if (localeAdjustment.m_Locale == locale)
				{
					return localeAdjustment;
				}
			}
			return null;
		}

		// Token: 0x06011C30 RID: 72752 RVA: 0x004C9D6C File Offset: 0x004C7F6C
		public UberText.LocalizationSettings.LocaleAdjustment AddLocale(Locale locale)
		{
			UberText.LocalizationSettings.LocaleAdjustment localeAdjustment = this.GetLocale(locale);
			if (localeAdjustment != null)
			{
				return localeAdjustment;
			}
			localeAdjustment = new UberText.LocalizationSettings.LocaleAdjustment(locale);
			this.m_LocaleAdjustments.Add(localeAdjustment);
			return localeAdjustment;
		}

		// Token: 0x06011C31 RID: 72753 RVA: 0x004C9D9C File Offset: 0x004C7F9C
		public void RemoveLocale(Locale locale)
		{
			for (int i = 0; i < this.m_LocaleAdjustments.Count; i++)
			{
				if (this.m_LocaleAdjustments[i].m_Locale == locale)
				{
					this.m_LocaleAdjustments.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x0400D78B RID: 55179
		public List<UberText.LocalizationSettings.LocaleAdjustment> m_LocaleAdjustments;

		// Token: 0x0200260F RID: 9743
		[Serializable]
		public class LocaleAdjustment
		{
			// Token: 0x060123C0 RID: 74688 RVA: 0x004D4560 File Offset: 0x004D2760
			public LocaleAdjustment()
			{
				this.m_Locale = Locale.enUS;
			}

			// Token: 0x060123C1 RID: 74689 RVA: 0x004D45BC File Offset: 0x004D27BC
			public LocaleAdjustment(Locale locale)
			{
				this.m_Locale = locale;
			}

			// Token: 0x0400E235 RID: 57909
			public Locale m_Locale;

			// Token: 0x0400E236 RID: 57910
			public float m_LineSpaceModifier = 1f;

			// Token: 0x0400E237 RID: 57911
			public float m_SingleLineAdjustment;

			// Token: 0x0400E238 RID: 57912
			public float m_Width;

			// Token: 0x0400E239 RID: 57913
			public float m_Height;

			// Token: 0x0400E23A RID: 57914
			public float m_FontSizeModifier = 1f;

			// Token: 0x0400E23B RID: 57915
			public float m_UnderwearWidth;

			// Token: 0x0400E23C RID: 57916
			public float m_UnderwearHeight;

			// Token: 0x0400E23D RID: 57917
			public float m_OutlineModifier = 1f;

			// Token: 0x0400E23E RID: 57918
			public float m_UnboundCharacterSizeModifier = 1f;

			// Token: 0x0400E23F RID: 57919
			public float m_ResizeToFitWidthModifier = 1f;

			// Token: 0x0400E240 RID: 57920
			public Vector3 m_PositionOffset = Vector3.zero;
		}
	}

	// Token: 0x02002349 RID: 9033
	private class CachedTextKeyData
	{
		// Token: 0x06011C32 RID: 72754 RVA: 0x004C9DE0 File Offset: 0x004C7FE0
		public override int GetHashCode()
		{
			return this.m_Text.Length + this.m_FontSize + this.m_Text.GetHashCode() + this.m_FontSize.GetHashCode() - this.m_CharSize.GetHashCode() + this.m_Width.GetHashCode() - this.m_Height.GetHashCode() + this.m_Font.GetHashCode() - this.m_LineSpacing.GetHashCode();
		}

		// Token: 0x0400D78C RID: 55180
		public string m_Text;

		// Token: 0x0400D78D RID: 55181
		public int m_FontSize;

		// Token: 0x0400D78E RID: 55182
		public float m_CharSize;

		// Token: 0x0400D78F RID: 55183
		public float m_Width;

		// Token: 0x0400D790 RID: 55184
		public float m_Height;

		// Token: 0x0400D791 RID: 55185
		public Font m_Font;

		// Token: 0x0400D792 RID: 55186
		public float m_LineSpacing;
	}

	// Token: 0x0200234A RID: 9034
	[Serializable]
	private class CachedTextValues
	{
		// Token: 0x0400D793 RID: 55187
		public string m_Text;

		// Token: 0x0400D794 RID: 55188
		public float m_CharSize;

		// Token: 0x0400D795 RID: 55189
		public int m_OriginalTextHash;
	}

	// Token: 0x0200234B RID: 9035
	public enum AlignmentOptions
	{
		// Token: 0x0400D797 RID: 55191
		Left,
		// Token: 0x0400D798 RID: 55192
		Center,
		// Token: 0x0400D799 RID: 55193
		Right
	}

	// Token: 0x0200234C RID: 9036
	public enum AnchorOptions
	{
		// Token: 0x0400D79B RID: 55195
		Upper,
		// Token: 0x0400D79C RID: 55196
		Middle,
		// Token: 0x0400D79D RID: 55197
		Lower
	}

	// Token: 0x0200234D RID: 9037
	private enum TextRenderMaterial
	{
		// Token: 0x0400D79F RID: 55199
		Text,
		// Token: 0x0400D7A0 RID: 55200
		Bold,
		// Token: 0x0400D7A1 RID: 55201
		Outline,
		// Token: 0x0400D7A2 RID: 55202
		InlineImages
	}

	// Token: 0x0200234E RID: 9038
	private enum Fonts
	{
		// Token: 0x0400D7A4 RID: 55204
		BlizzardGlobal,
		// Token: 0x0400D7A5 RID: 55205
		Belwe,
		// Token: 0x0400D7A6 RID: 55206
		BelweOutline,
		// Token: 0x0400D7A7 RID: 55207
		FranklinGothic
	}

	// Token: 0x0200234F RID: 9039
	private enum ThaiGlyphType
	{
		// Token: 0x0400D7A9 RID: 55209
		BASE,
		// Token: 0x0400D7AA RID: 55210
		BASE_ASCENDER,
		// Token: 0x0400D7AB RID: 55211
		BASE_DESCENDER,
		// Token: 0x0400D7AC RID: 55212
		TONE_MARK,
		// Token: 0x0400D7AD RID: 55213
		UPPER,
		// Token: 0x0400D7AE RID: 55214
		LOWER
	}
	*/
}
