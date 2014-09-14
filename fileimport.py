import csv
import os

root = 'c:\\import\\'
os.chdir(root)

def importing():
	for file in os.listdir(root):
		with open(file, 'rb') as f:
			reader = csv.reader(f, delimiter = '|', quoting = csv.QUOTE_MINIMAL)
			with open('file.111', 'wb') as outfile:
				writer = csv.writer(outfile,delimiter = '|', quoting = csv.QUOTE_MINIMAL)
				for row in reader:
					if row[5] == "6":
						row.append(row[5])
						writer.writerow(row)
importing()