function DownloadFile(fileName, fileContent, fileExtension) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = "data:application/" + fileExtension + ";charset=utf-8," + encodeURIComponent(fileContent);
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
