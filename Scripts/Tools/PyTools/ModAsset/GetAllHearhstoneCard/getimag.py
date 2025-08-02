import requests

url = "https://api.hearthstonejson.com/v1/latest/enUS/cards.collectible.json"

response = requests.get(url)

print(response.content)

with open("us.json","wb") as f:
	f.write(response.content)