const Toast = Swal.mixin({
    toast: true,
    position: 'top-end',
    customClass: 'swal-wide',
    showConfirmButton: false,
    timer: 2000,
    timerProgressBar: true,
    didOpen: (toast) => {
        toast.addEventListener('mouseenter', Swal.stopTimer)
        toast.addEventListener('mouseleave', Swal.resumeTimer)
    }
})

window.Toaster = (type, message) => Toast.fire({
    icon: type,
    title: message
})