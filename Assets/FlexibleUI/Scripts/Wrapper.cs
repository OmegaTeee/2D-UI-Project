using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace VisualDesign.FlexibleUI
{
	public class Wrapper : WrapperInitializer
	{

		public WrapperData assetData; // Reference to ScriptableObject

		// public GameObject ComponentContainer;
		public TextMeshProUGUI ComponentText; // Reference to the TextMeshProUGUI component (TextMesh Pro for UI)
		public Button ComponentButton; // Reference to the Button component

		public override void Setup()
		{
			// ComponentContainer = GetComponent<RectTransform>();
			ComponentButton = GetComponentInChildren<Button>();
			ComponentText = GetComponentInChildren<TextMeshProUGUI>();
		}

		public override void Configure()
		{
			if (assetData == null)
			{
				Debug.LogError("No SO Data assigned!");
				return;
			}

			// Apply the text content
			if (ComponentText != null)
			{
				ComponentText.text = assetData.textContent;
				ComponentText.color = assetData.textColor;
				ComponentText.fontSize = assetData.fontSize;
			}

			// Apply the background color and size for Button
			if (ComponentButton != null)
			{
				// Update the button's background color
				var buttonImage = ComponentButton.GetComponent<Image>();
				if (buttonImage != null)
				{
					buttonImage.color = assetData.backgroundColor;
				}

				// Update the wrapper's size
				// var rectTransform = ComponentContainer.GetComponent<RectTransform>();
				// if (rectTransform != null) {
				// 	rectTransform.sizeDelta = assetData.size;
				// }
			}
		}
	}
}