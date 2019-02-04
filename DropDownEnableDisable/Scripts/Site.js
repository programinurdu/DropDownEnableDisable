function enabledisabletextbox(val) {
    if (val === 'Yes' || val === '') {
        document.getElementById('CommentIfExempt').disabled = true;
        document.getElementById('CommentIfExempt').value = "";
    }
    else {
        document.getElementById('CommentIfExempt').disabled = false;
    }
}